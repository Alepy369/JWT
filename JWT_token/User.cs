using System;

public class User
{
	public string Username { get; set; } = string.Empty;
	public byte[] PasswordSalt { get; set; }
	public byte[] PasswordHash { get; set;}

}
