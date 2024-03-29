﻿using S4_BmBackend.DTO;

namespace S4_BmBackend.Logic
{
    public class WeightProfile
    {
        public List<User> users = new List<User>();
        public User CreateUser(int id, string name, string email, string password, string adress, int age, int lenght, DateTime birthday)
        {
            User user = new(id, name, email, password, adress, age, lenght, birthday);
            users.Add(user);
            return user;
        }

        public void AddData(Weight weight, Goal goal, PersonalTrainer personalTrainer, int id)
        {
            //User user = (User)users.Select(user => user.Id = id);
            if (users[0].Id == id)
            {
                User user = users[0];
                user.Weight = weight;
                user.Goal = goal;
                user.PersonalTrainer = personalTrainer;
            }
        }
    }
}
