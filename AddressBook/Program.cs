var addressBook = new AddressBook();

List<Contact> cachedContacts = new List<Contact>();

for (int i = 0; i < 5; i++)
{
    string firstName = string.Empty;
    string lastName = string.Empty;
    string email = string.Empty;
    string phone = string.Empty;

    Console.Write("Enter first name: ");
    firstName = Console.ReadLine();
    Console.Write("Enter Last name: ");
    lastName = Console.ReadLine();
    Console.Write("Enter phone: ");
    phone = Console.ReadLine();
    Console.Write("Enter email: ");
    email = Console.ReadLine();
    var contact = new Contact(firstName,lastName, phone, email);
    addressBook.AddContact(contact);
    cachedContacts.Add(contact);
}

Console.WriteLine("Printing contacts");
addressBook.PrintContacts();

Console.WriteLine("Sorting contacts");
addressBook.SortContacts();
addressBook.PrintContacts();

for (int i = 0; 1< 5; i++)
{
    Console.WriteLine("Remove contact :" + cachedContacts[i]);
    addressBook.RemoveContact(cachedContacts[i]);
    addressBook.PrintContacts();
}