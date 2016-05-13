using System;


namespace SimpleTeam.Use
{
    public interface IUserProfile
    {
        String Nick { get; set; }
        bool IsSignIn { get; }
    }
}
