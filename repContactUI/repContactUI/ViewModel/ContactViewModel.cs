using System;
using System.Collections.ObjectModel;
using ContactsMessageUI.Models;
using repContactUI.Models;

namespace ContactsMessageUI.ViewModels
{
    public class ContactsViewModel
    {
        public ObservableCollection<Contacts> contacts { get; set; }
        public ObservableCollection<ContactStatus> contactsStatus { get; set; }
        public ObservableCollection<Messages> messages { get; set; }

        public ContactsViewModel()
        {
            contacts = new ObservableCollection<Contacts>()
            {
                new Contacts{ Name ="Marc", Picture="Marc"},
                new Contacts{ Name ="Sandy", Picture="Sandy"},
                new Contacts{ Name ="Lucie", Picture="Lucie"},
                new Contacts{ Name ="Laura", Picture="Laura"},
                new Contacts{ Name ="Martin", Picture="Martin"}
            };

            contactsStatus = new ObservableCollection<ContactStatus>()
            {
                new ContactStatus { Picture = "Alice", Name="Alice" , StatusComment="Online", IsOnline=true},
                new ContactStatus { Picture = "Pauline", Name="Pauline" , StatusComment="Online", IsOnline=true},
                new ContactStatus { Picture = "Martin", Name="Martin" , StatusComment="Online", IsOnline=true},
                new ContactStatus { Picture = "Fanny", Name="Fanny" , StatusComment="Last activity 35 min", IsOnline=false },
                new ContactStatus { Picture = "Celine", Name="Celine" , StatusComment="Last activity 25 min", IsOnline=false}
            };

            messages = new ObservableCollection<Messages>()
            {
                new Messages { Picture = "Alice", Name = "Alice", StatusComment = "Online", IsOnline = true , Comment="Enzo Ferrari was not initially interesed in the idea of producing road cars when he formed Scuderia Ferrari in 1929 😁, with headquarter in Modena.", CommentPicture="", IsCommentPicture=false },
                new Messages { Picture = "Martin", Name = "Martin", StatusComment = "Online", IsOnline = true, Comment="Yosemite Valley has been inhabited for nearly 3,000 yearly, although humans may have first  visited the area as long as 8,000 10 10,000 years ago.", CommentPicture="Yosemite", IsCommentPicture=true },
                new Messages { Picture = "Celine", Name = "Celine", StatusComment = "Offline", IsOnline = false , Comment="Enzo Ferrari was not initially interesed in the idea of producing road cars when he formed Scuderia Ferrari in 1929 😁, with headquarter in Modena.", CommentPicture="", IsCommentPicture=false },

            };
        }
    }
}