using Microsoft.EntityFrameworkCore;
using Npgsql;
using Test_Api.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;


/*Aquí estás creando una clase llamada Db que hereda de DbContext
, que es la clase principal en Entity Framework Core que gestiona 
la interacción con la base de datos. Es la clase encargada de realizar 
las operaciones CRUD 
(Crear, Leer, Actualizar, Borrar) sobre las entidades que defines.*/

namespace Test_Api.Data
{
    public class TestApiDbContext : DbContext
    {
        /*Sí, DbContextOptions<TContext> 
            es más que solo un parámetro básico; 
        es un objeto completamente configurado que 
            contiene todas las opciones necesarias para que 
            Entity Framework pueda interactuar correctamente 
            con la base de datos.*/

        public TestApiDbContext(DbContextOptions<TestApiDbContext> options) : base(options)
        {
        }


        public DbSet<Country> Countries => Set<Country>();

        public DbSet<Department> Departments => Set<Department>();

        public DbSet<Municipality> Municipalities => Set<Municipality>();

        public DbSet<Person> Persons => Set<Person>();

        public DbSet<User> Users => Set<User>();


        //Stored Procedures
        public void InsertDepartment(string nameDepartment)
        {
            var departmentNameParam = new NpgsqlParameter("p_name_department", nameDepartment);
            Database.ExecuteSqlRaw("CALL insert_departments(@p_name_department)", departmentNameParam);
        }

        public void insertMunicipality(string nameMunicipaliy) 
        {
            var municipalityNameParam = new NpgsqlParameter("p_name_municipality", nameMunicipaliy);
            Database.ExecuteSqlRaw("CALL insert_departments(@p_name_municipality)", municipalityNameParam);
        }

        public void insertCountry(string nameCountry)
        {
            var countryNameParam = new NpgsqlParameter("p_name_countries", nameCountry);
            Database.ExecuteSqlRaw("CALL insert_countries(@p_name_countries)", nameCountry);
        }

        public void insertPerson(string name, string phone, int idCountry, int idDepartment, int idMunicipality , string address) 
        {
            var personNameParam = new NpgsqlParameter("_name", name);
            var personPhoneParam = new NpgsqlParameter("_phone", phone);
            var personCountryParam = new NpgsqlParameter("_countryId", name);
            var personDeparmentParam = new NpgsqlParameter("_departmentId", name);
            var personMunicipalityParam = new NpgsqlParameter("_municipalityId", name);
            var personAddresParam = new NpgsqlParameter("_address", name);

            Database.ExecuteSqlRaw("CALL insert_person(@_name,@_phone,@_countryId,@_departmentId,@_municipalityId,@_address)", personNameParam, personPhoneParam, personCountryParam,
                                                                                                                                  personDeparmentParam, personMunicipalityParam, personAddresParam);
        }

        public void insertUser() 
        {

        }
    }
}
