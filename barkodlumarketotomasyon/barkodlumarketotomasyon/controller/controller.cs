using barkodlumarketotomasyon.dao;
using barkodlumarketotomasyon.enumaration;
using barkodlumarketotomasyon.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace barkodlumarketotomasyon.controller
{
    public class controller
    {
       private repository repository;
        public controller()
        {
            repository = new repository();
        }

        public user login(string kullaniciadi, string sifre)
        {
            user result;
            if (kullaniciadi != null && sifre != null)
            {
                result = repository.login(kullaniciadi, sifre);
                return result;
            }
            else
            {
                user user = new user();
                user.status = loginstatus.eksikparametre;
                return user;
            }
        }

        public List<logintable> guvenliksorulari()
        {
            return repository.guvenliksorulari();
        }

        public loginstatus doauthentication(string kullaniciadi, string guvenliksorusu, string guvenlikcevabi)
        {
            if (!string.IsNullOrEmpty(kullaniciadi) || !string.IsNullOrEmpty(guvenliksorusu) || !string.IsNullOrEmpty(guvenlikcevabi))
            {
                loginstatus result = repository.doauthentication(kullaniciadi, guvenliksorusu, guvenlikcevabi);

                if (result == loginstatus.basarili)
                {
                    return result;
                }
                else
                {
                    return loginstatus.basarisiz;
                }

            }
            else
            {
               return loginstatus.eksikparametre;
            }
        }
        public loginstatus changepassword(string kullaniciadi,string sifre)
        {
            if(!string.IsNullOrEmpty(kullaniciadi) && !string.IsNullOrEmpty(sifre))
            {
                return repository.changepassword(kullaniciadi, sifre);
            }
            else
            {
                return loginstatus.eksikparametre;
            }
        }
        public urun urungetir(string barkod)
        {
            if (!string.IsNullOrEmpty(barkod))
            {
                return repository.urungetir(barkod);
            }
            else
            {
                return null;
            }
        }
        public List<user> tumkullanicilarigetir()
        {
            controller controller = new controller();
            return repository.tumkullanicilarigetir();
        }
        public loginstatus kullaniciekle(user user)
        {
            if (!string.IsNullOrEmpty(user.kullaniciadi) && !string.IsNullOrEmpty(user.sifre) && !string.IsNullOrEmpty(user.yetki)&&!string.IsNullOrEmpty(user.guvenliksorusu)&&!string.IsNullOrEmpty(user.guvenlikcevabi)){
                controller controller = new controller();
                loginstatus sonuc = repository.kullaniciekle(user);
                return sonuc;

            }
            else
            {
                return loginstatus.eksikparametre;
            }
        }
        public loginstatus kullaniciguncelle(user user)
        {
            return repository.kullaniciguncelle(user);
        }

        public loginstatus kullanicisilme(int id)
        {
            if (!string.IsNullOrEmpty(id.ToString())){
                return repository.kullanicisilme(id);
            }
            else
            {
                return loginstatus.eksikparametre;
            }
             
        }
        public List<urun> tumurunlerigetir()
        {
            return repository.tumurunlerigetir();

        }
        public loginstatus urunekle(urun urun)
        {
            if(!string.IsNullOrEmpty(urun.urun_isim) && !string.IsNullOrEmpty(urun.barkodkod))
            {
                return repository.urunekle(urun);
            }
            else
            {
                return loginstatus.eksikparametre;
            }
        }
        public loginstatus urunguncelle(urun urun)
        {
            if(!string.IsNullOrEmpty(urun.urun_isim) && !string.IsNullOrEmpty(urun.barkodkod))
            {
                return repository.urunguncelle(urun);
            }
            else
            {
                return loginstatus.eksikparametre;
            }
        }
        public loginstatus urunsil(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                return repository.urunsil(id);
            }
            else
            {
                return loginstatus.eksikparametre;
            }
        }
    }

    }
