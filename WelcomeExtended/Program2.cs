using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;
using WelcomeExtended.Data;
using static WelcomeExtended.Others.Delegates;
using WelcomeExtended.Helpers;


namespace WelcomeExtended
{
    class Program2
    {
        static void Main(string[] args)
        {
            //uprajnenie 2
            //try
            //{
            //    var user = new User
            //    {
            //        Names = "Momchil Dimitrov",
            //        Passwords = "momchi2008",
            //        Roles = UserRolesEnum.STUDENT
            //    };

            //    var viewModel = new UserViewModel(user);

            //    var view = new UserView(viewModel);

            //    view.Display();

            //    view.DisplayError();


            //}
            //catch (Exception e)
            //{
            //    var log = new ActionOnError(Log);
            //    log(e.Message);
            //}

            //finally
            //{
            //    Console.WriteLine("Executed in any case");

            //}

            try
            {
                UserData userData = new UserData();

                User studentUser = new User()
                {
                    Names = "student",
                    Passwords = "123",
                    Roles = UserRolesEnum.STUDENT

                };
                userData.AddUser(studentUser);

                User student2 = new User()
                {
                    Names = "Student2",
                    Passwords = "123",
                    Roles = UserRolesEnum.STUDENT

                };
                userData.AddUser(student2);

                User teacher = new User()
                {
                    Names = "Teacher",
                    Passwords = "1234",
                    Roles = UserRolesEnum.PROFESSOR

                };
                userData.AddUser(teacher);

                Console.WriteLine("Please insert your credentials");
                Console.Write("Name:");
                var name = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Password:");
                var password = Console.ReadLine();
                Console.WriteLine();
                var user = new User();
                if (userData.ValidateCredentials(name, password) == true)
                {
                    user = userData.GetUser(name, password);
                    Console.WriteLine(user.ConvertToString());

                }
                else
                {
                    Console.WriteLine("The user does not exisist");
                }

            }

            catch (Exception e)
            {
                var log = new ActionOnError(Log);
                log(e.Message);
            }

            finally
            {
                Console.WriteLine("Executed in any case");

            }

        }
    }
}
