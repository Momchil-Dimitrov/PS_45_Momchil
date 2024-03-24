using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;

namespace Welcome
{
    public class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.Names = "Momchil";
            user1.Passwords = "momdimitrov";
            user1.Roles = Others.UserRolesEnum.STUDENT;
            UserViewModel uservm1 = new UserViewModel(user1);
            UserView userv1 = new UserView(uservm1);
            userv1.Display();

        }
    }
}
