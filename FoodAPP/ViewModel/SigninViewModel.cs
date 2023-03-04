﻿using FoodAPP.View;using System.ComponentModel;using System.Runtime.CompilerServices;using System.Windows.Input;namespace FoodAPP.ViewModel{	internal class SigninViewModel : INotifyPropertyChanged	{		public static int user_id;		public static String user_name;		public static String user_surname;		public static String user_email;		public string Mail { get; set; }		public string Password { get; set; }		public event PropertyChangedEventHandler PropertyChanged;		public ICommand SignupCommand => new Command(OnSignupClicked);		public ICommand SigninCommand => new Command(OnSigninClicked);

		private async void OnSignupClicked()		{			await Shell.Current.GoToAsync(nameof(Signup));		}		private async void OnSigninClicked(object obj)		{			var signindata = await App.Database.GetLoginDataAsync(Mail);			if (signindata != null)			{				if (string.Equals(Password, signindata.Password))				{					user_id = signindata.ID;					user_email = signindata.Email;					user_name = signindata.Name;					user_surname = signindata.SurName;					await Shell.Current.GoToAsync(nameof(Fridge));				}				else				{					await Application.Current.MainPage.DisplayAlert("ERROR!", "Uncorrect password", "OK");				}			}			else			{				await Application.Current.MainPage.DisplayAlert("ERROR!", "Uncorrect mail", "OK");			}		}		public void OnPropertyChanged([CallerMemberName] string str = null)		{			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(str));		}	}}