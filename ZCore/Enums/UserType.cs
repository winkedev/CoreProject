using System;

namespace ZCore.Enums
{
    public enum UserType
    {
        Unknown,
        Normal,
        Administrator
    }

    public static class UserTypeExtensions
    {
        public static string GetName(this UserType t)
        {
            switch (t)
            {
                case UserType.Normal:
                    return "Normal";
                case UserType.Administrator:
                    return "Administrator";
                case UserType.Unknown:
                default:
                    return "Unknown";
            }
        }

        public static int GetCode(this UserType t)
        {
            switch (t)
            {
                case UserType.Normal:
                    return 0;
                case UserType.Administrator:
                    return 1;
                case UserType.Unknown:
                default:
                    return -1;
            }
        }

        public static UserType FromCode(this UserType t, int code)
        {
            foreach (UserType v in Enum.GetValues(typeof(UserType)))
            {
                if (v.GetCode() == code)
                {
                    return v;
                }
            }

            return t;
        }

        public static UserType FromName(this UserType t, string name)
        {
            foreach(UserType v in Enum.GetValues(typeof(UserType)))
            {
                if (v.GetName().Equals(name, StringComparison.InvariantCultureIgnoreCase))
                {
                    return v;
                }
            }

            return t;
        }
    }
}
