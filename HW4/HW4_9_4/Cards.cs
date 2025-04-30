using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_9_4
{
    public class Cards
    {
        public string Name;
        public string Occupation;
        public int Age;
        public PhoneList Phone;
        public string Email;

        public Cards(string name, string occupation, int age, PhoneList phone, string email)
        {
            Name = name;
            Occupation = occupation;
            Age = age;
            Phone = phone;
            Email = email;
        }

        public string GetCard()
        {
            return $"姓名: {Name}\n職業: {Occupation}\n年齡: {Age}\nEmail: {Email}\n" +
                   $"住家電話: {Phone.HomePhone}\n公司電話: {Phone.BusinessPhone}\n手機: {Phone.CellPhone}";
        }
    }

}
