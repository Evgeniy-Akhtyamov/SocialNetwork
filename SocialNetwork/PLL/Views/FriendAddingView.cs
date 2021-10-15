using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class FriendAddingView
    {
        UserService userService;
        
        public FriendAddingView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show(User user)
        {
            var friendAddingData = new FriendAddingData();

            Console.Write("Введите почтовый адрес друга: ");
            friendAddingData.FriendEmail = Console.ReadLine();

            friendAddingData.User_id = user.Id;

            try
            {
                userService.AddFriend(friendAddingData);
                SuccessMessage.Show($"Пользователь с электронной почтой {friendAddingData.FriendEmail} успешно добавлен в друзья!");
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователь не найден!");
            }
                        
            catch (Exception)
            {
                AlertMessage.Show("Произошла ошибка при добавлении друга!");
            }
        }
    }
}
