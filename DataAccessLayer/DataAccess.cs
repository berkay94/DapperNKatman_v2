using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace DataAccessLayer
{
    public class DataAccess
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter datp;
        SqlDataReader rdr;
        string constr = "Data Source=10.10.22.199;Initial Catalog=test;User ID=test2;Password=test2";

        public DataAccess()
        {
            con = new SqlConnection(constr);
        }

        public int PersonelKaydet(Personel p)
        {
            int kayitsayisi = 0;
            string sql = "Insert into Calisan(Ad,Soyad,telefon,email,maas,Sehir,Departman) Values(@ad,@soyad,@telefon,@email,@maas,@sehir,@departman)";
           kayitsayisi= con.Execute(sql,new {@ad =p.Ad,@soyad=p.Soyad,@telefon=p.telefon,@email=p.email,@maas=p.maas,@sehir=p.sehir,@departman=p.departman});
            return kayitsayisi;


            
        }

        public int LoginKontrol(User u)
        {
            int kayitsayisi = 0;
            var user=con.Query<User>("Select uid,email,islogin from Users Where email=@email and password=@password", new { @email = u.email, @password = u.password });

            if(user.Count()>0)
            {
                kayitsayisi = 1;
            }

            return kayitsayisi;
        }
    }
}
