using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc3_1B_gayaoyj_hms
{
public class Account
{
    public int ID { get; }
    private string Password { get; }

    public Account(int id, string password)
    {
        ID = id;
        Password = password;
    }

    public bool ValidatePassword(string inputPassword)
    {
        return Password == inputPassword;
    }
} }