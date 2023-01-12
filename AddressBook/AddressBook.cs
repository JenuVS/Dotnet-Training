public class AddressBook
{
    // Fields
    private List <Contact> _contacts;

    public AddressBook()
    {
        _contacts = new List<Contact>();
    }

    public void AddContact(Contact contact)
    {
        _contacts.Add(contact);

    }

    public void RemoveContact(Contact contact)
    {
        _contacts.Remove(contact);
    }

    public void SortContacts()
    {
        _contacts.Sort((name1, name2) => name1.FirstName.CompareTo(name2.FirstName));
    }

    public void PrintContacts()
    {
        foreach (var item in _contacts)
        {
            Console.WriteLine(item);
        }
    }

}