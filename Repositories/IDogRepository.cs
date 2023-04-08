﻿using DogGo.Models;
using Microsoft.Data.SqlClient;

namespace DogGo.Repositories
{
    public interface IDogRepository
    {
        SqlConnection Connection { get; }

        void AddDog(Dog dog);
        void DeleteDog(int dogId);
        List<Dog> GetAllDogs();
        Dog GetDogById(int id);
        void UpdateDog(Dog dog);
    }
}