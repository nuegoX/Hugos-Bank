using Bank;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

public class AccountManager
{
    private List<Account> accounts;
    private string filePath;

    public AccountManager(string filePath)
    {
        this.filePath = filePath;
        accounts = new List<Account>();
    }

    public AccountManager(string filePath, List<Account> existingAccounts)
    {
        this.filePath = filePath;
        existingAccounts = accounts;
    }

    public void AddAccount(Account account)
    {
        accounts.Add(account);
    }

    public void SaveToFile()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Account>));
        using (TextWriter writer = new StreamWriter(filePath))
        {
            serializer.Serialize(writer, accounts);
        }
    }

    public void LoadFromFile()
    {
        if (File.Exists(filePath))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Account>));
            using (TextReader reader = new StreamReader(filePath))
            {
                accounts = (List<Account>)serializer.Deserialize(reader);
            }
        }
    }

    public List<Account> GetAllAccounts()
    {
        return accounts;
    }
}
