namespace Tubes_KPL
{
    class TableDriven
    {
        public enum Username { root, admin, user, gilang, dzakwan, akbar, adam, toto};
        public static string[] password = { "root123", "admin123", "user123", "gilang123", "dzakwan123", "akbar123", "adam123", "toto123"};

        public static string getKodeUser(Username username)
        {
            return password[(int)username];
        }

    }
}
