using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml;
using Assignment3.Utility;

namespace Assignment3.Tests
{
    public static class SerializationHelper
    {
        /// <summary>
        /// Serializes (encodes) users
        /// </summary>
        /// <param name="users">List of users</param>
        /// <param name="fileName"></param>
        public static void SerializeUsers(ILinkedListADT<User> users, string fileName)
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(List<User>));
            using (FileStream stream = File.Create(fileName))
            using (XmlWriter writer = XmlWriter.Create(stream))
            {
                serializer.WriteObject(writer, users.ToArray());
            }
        }

        /// <summary>
        /// Deserializes (decodes) users
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>List of users</returns>
        public static ILinkedListADT<User> DeserializeUsers(string fileName)
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(User[]));
            using (FileStream stream = File.OpenRead(fileName))
            using (XmlReader reader = XmlReader.Create(stream))
            {
                User[] usersArray = (User[])serializer.ReadObject(reader);
                ILinkedListADT<User> usersList = new SLL<User>();
                foreach (var user in usersArray)
                {
                    usersList.AddLast(user);
                }
                return usersList;
            }
        }
    }
}
