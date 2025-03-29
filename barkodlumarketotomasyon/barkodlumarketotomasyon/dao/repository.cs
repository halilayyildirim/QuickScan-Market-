using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using barkodlumarketotomasyon.enumaration;
using barkodlumarketotomasyon.model;

namespace barkodlumarketotomasyon.dao
{
    public class repository
    {
        private readonly SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader dr;
        private int returnvalue;
        private List<logintable> logintableliste;

        public repository()
        {
            con = new SqlConnection(@"Data Source=HALIL\SQLEXPRESS;Initial Catalog=market;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        }

        public user login(string kullaniciadi, string sifre)
        {
            con.Open();
            cmd = new SqlCommand("select * from logintable where kullaniciadi=@kullaniciadi and sifre=@sifre", con);
            cmd.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                user user = new user();
                user.id = int.Parse(dr["id"].ToString());
                user.kullaniciadi = (dr["kullaniciadi"].ToString());
                user.sifre = (dr["sifre"].ToString());
                user.yetki = (dr["yetki"].ToString());
                user.emailadres = (dr["emailadres"].ToString());
                user.guvenliksorusu = (dr["guvenliksorusu"].ToString());
                user.guvenlikcevabi = (dr["guvenlikcevabi"].ToString());
                user.status = loginstatus.basarili;
                return user;
            }
            else
            {
                user user = new user();
                user.status = loginstatus.basarisiz;
                return user;
            }
        }

        public List<logintable> guvenliksorulari()
        {
            logintableliste = new List<logintable>();
            try
            {
                con.Open();
                cmd = new SqlCommand("guvenliksorusugetir_sp", con)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    logintable logintable = new logintable
                    {
                        id = dr["id"] != DBNull.Value ? Convert.ToInt32(dr["id"]) : 0,
                        kullaniciadi = dr["kullaniciadi"]?.ToString(),
                        sifre = dr["sifre"]?.ToString(),
                        yetki = dr["yetki"]?.ToString(),
                        guvenliksorusu = dr["guvenliksorusu"]?.ToString(),
                        guvenlikcevabi = dr["guvenlikcevabi"]?.ToString(),
                        gmailadres = dr["emailadres"]?.ToString()
                    };
                    logintableliste.Add(logintable);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Güvenlik soruları getirme hatası: " + ex.Message);
            }
            finally
            {
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return logintableliste;
        }

        public loginstatus doauthentication(string kullaniciadi, string guvenliksorusu, string guvenlikcevabi)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select count(*) from logintable where kullaniciadi=@kulad and guvenliksorusu=@guvsorusu and guvenlikcevabi=@guvcevabi", con);
                cmd.Parameters.AddWithValue("@kulad", kullaniciadi);
                cmd.Parameters.AddWithValue("@guvsorusu", guvenliksorusu);
                cmd.Parameters.AddWithValue("@guvcevabi", guvenlikcevabi);

                returnvalue = Convert.ToInt32(cmd.ExecuteScalar());
                return returnvalue == 1 ? loginstatus.basarili : loginstatus.basarisiz;
            }
            catch (Exception ex)
            {
                Console.WriteLine("DoAuthentication hatası: " + ex.Message);
                return loginstatus.basarisiz;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        public loginstatus changepassword(string kullaniciadi, string sifre)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("sifreguncelle_sp", con)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
                cmd.Parameters.AddWithValue("@sifre", sifre);

                returnvalue = cmd.ExecuteNonQuery();
                return returnvalue > 0 ? loginstatus.basarili : loginstatus.basarisiz;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Şifre güncelleme hatası: " + ex.Message);
                return loginstatus.basarisiz;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        public urun urungetir(string barkod)
        {
            con.Open();
            cmd = new SqlCommand("select * from urun where barkodkod=@code", con);
            cmd.Parameters.AddWithValue("@code", barkod);
            dr = cmd.ExecuteReader();
            urun urun = new urun();
            while (dr.Read())
            {

                urun.id = int.Parse(dr["id"].ToString());
                urun.qrkod = dr["qrkod"].ToString();
                urun.barkodkod = dr["barkodkod"].ToString();


                urun.urun_isim = dr["urun_isim"].ToString();
                urun.kilo = int.Parse(dr["kilo"].ToString());
                urun.fiyat = int.Parse(dr["fiyat"].ToString());





            }
            con.Close();
            return urun;
        }
        public List<user> tumkullanicilarigetir()
        {
            List<user> userlist = new List<user>();
            con.Open();
            cmd = new SqlCommand("select * from logintable", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                user user = new user();
                user.id = int.Parse(dr["id"].ToString());
                user.kullaniciadi = dr["kullaniciadi"].ToString();
                user.sifre = dr["sifre"].ToString();
                user.yetki = dr["yetki"].ToString();
                user.guvenliksorusu = dr["guvenliksorusu"].ToString();
                user.guvenlikcevabi = dr["guvenlikcevabi"].ToString();
                user.emailadres = dr["emailadres"].ToString();
                userlist.Add(user);

                
                


            }
            con.Close();
            return userlist;
        }
        public loginstatus kullaniciekle(user user)
        {
            con.Open();
            cmd = new SqlCommand("kullaniciekle_sp", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@kullaniciadi",user.kullaniciadi);
            cmd.Parameters.AddWithValue("@sifre", user.sifre);
            cmd.Parameters.AddWithValue("@yetki", user.yetki);
            cmd.Parameters.AddWithValue("@emailadres", user.emailadres);
            cmd.Parameters.AddWithValue("@guvenliksorusu", user.guvenliksorusu);
            cmd.Parameters.AddWithValue("@guvenlikcevabi", user.guvenlikcevabi);
            int returnvalue = cmd.ExecuteNonQuery();
            
                con.Close();
            if (returnvalue == 1)
            {
                return loginstatus.basarili;
            }
            else
            {
                return loginstatus.basarisiz;
            }

        }
        public loginstatus kullaniciguncelle(user user) {
            con.Open();
            cmd = new SqlCommand("kullaniciguncelle_sp",con);
            cmd.CommandType= System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id",user.id);
            cmd.Parameters.AddWithValue("@kullaniciadi", user.kullaniciadi);
            cmd.Parameters.AddWithValue("@sifre", user.sifre);
            cmd.Parameters.AddWithValue("@yetki", user.yetki);
            cmd.Parameters.AddWithValue("@emailadres", user.emailadres);
            cmd.Parameters.AddWithValue("@guvenliksorusu", user.guvenliksorusu);
            cmd.Parameters.AddWithValue("@guvenlikcevabi", user.guvenlikcevabi);
            int returnvalue = cmd.ExecuteNonQuery();
            con.Close();
            if (returnvalue == 1)
            {
                return loginstatus.basarili;
            }
            else
            {
                return loginstatus.basarisiz;
            }

        }
        public loginstatus kullanicisilme(int id )
        {
            con.Open();
            cmd = new SqlCommand("delete from logintabel where id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            int returnvalue = cmd.ExecuteNonQuery();
            con.Close();
            if (returnvalue == 1) {
                return loginstatus.basarili;
            }
            else
            {
                return loginstatus.basarisiz;   
            }
            
        }
        public List<urun> tumurunlerigetir()
        {
            List<urun> urunlist = new List<urun>();
            con.Open();
            cmd = new SqlCommand("select * from urun", con);
            dr= cmd.ExecuteReader();
            while (dr.Read()){
                urun urun = new urun();
                urun.id = int.Parse(dr["id"].ToString());
                urun.qrkod= dr["qrkod"].ToString();
                urun.barkodkod = dr["barkodkod"].ToString();
                urun.olusturulma_traih =DateTime.Parse(dr["olusturulma_traih"].ToString());
                if (!string.IsNullOrEmpty(dr["guncelleme_tarih"].ToString()))
                {
                    urun.guncelleme_tarih = DateTime.Parse(dr["guncelleme_tarih"].ToString());
                }
                urun.urun_isim = dr["urun_isim"].ToString();
                urun.kilo=float.Parse(dr["kilo"].ToString());
                urun.ciro =int.Parse(dr["ciro"].ToString());
                urunlist.Add(urun);
            }

            con.Close();
             return urunlist;
        }
        public loginstatus urunekle(urun urun)
        {
            con.Open();
            cmd = new SqlCommand("urunekle_sp", con);
            cmd.CommandType=System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("id", urun.id);
            cmd.Parameters.AddWithValue ("qrkod", urun.qrkod);
            cmd.Parameters.AddWithValue("barkodkod", urun.barkodkod);
            cmd.Parameters.AddWithValue("olusturulma_traih", urun.olusturulma_traih);
            cmd.Parameters.AddWithValue("guncelleme_tarih", urun.guncelleme_tarih);
            cmd.Parameters.AddWithValue("urun_isim", urun.urun_isim);
            cmd.Parameters.AddWithValue("kilo", urun.kilo);
            cmd.Parameters.AddWithValue("ciro", urun.ciro);
            int returnvalue = cmd.ExecuteNonQuery();
            con.Close();
            if (returnvalue == 1)
            {
                return loginstatus.basarili;
            }
            else {
                return loginstatus.basarisiz;
            }
        }
        public loginstatus urunguncelle(urun urun)
        {
            con.Open();
            cmd = new SqlCommand("urunguncelle_sp", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd = new SqlCommand("urunekle_sp", con);
            cmd.Parameters.AddWithValue("id", urun.id);
            cmd.Parameters.AddWithValue("qrkod", urun.qrkod);
            cmd.Parameters.AddWithValue("barkodkod", urun.barkodkod);
            cmd.Parameters.AddWithValue("olusturulma_traih", urun.olusturulma_traih);
            cmd.Parameters.AddWithValue("guncelleme_tarih", urun.guncelleme_tarih);
            cmd.Parameters.AddWithValue("urun_isim", urun.urun_isim);
            cmd.Parameters.AddWithValue("kilo", urun.kilo);
            cmd.Parameters.AddWithValue("ciro", urun.ciro);
            int returnvalue= cmd.ExecuteNonQuery(); 
            con.Close();
            if (returnvalue == 1){
                return loginstatus.basarili;
            }
            else
            {
                return loginstatus.basarisiz;
            }

        }
        public loginstatus urunsil(string id)
        {
            con.Open();
            cmd = new SqlCommand("delete from urun where id=@id", con);
            cmd.Parameters.AddWithValue("@id", id);
           int returnvalue= cmd.ExecuteNonQuery();
            con.Close();
            if (returnvalue == 1)
            {
                return loginstatus.basarili;
            }
            else
            {
                return loginstatus.basarisiz;
            }
               
        }
    }
}