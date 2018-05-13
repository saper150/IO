using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO {

    public class Geo {
        public string Lat { get; set; }
        public string Lng { get; set; }
    }

    public class Address {
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public Geo Geo { get; set; }
    }

    public class Company {
        public string Name { get; set; }
        public string CatchPhrase { get; set; }
        public string Bs { get; set; }
    }

    public class Post {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    public class User {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public Company Company { get; set; }
        public IEnumerable<Post> Posts { get; set; }
    }



    static class AthApi {

        private static IEnumerable<Post> GetPosts(int userId) {
            foreach (var item in Http.Get<IEnumerable<Post>>($"https://jsonplaceholder.typicode.com/posts?userId={userId}")) {
                yield return item;
            }
        }

        public static IEnumerable<User> GetUsers() {
            var users = Http.Get<IEnumerable<User>>($"https://jsonplaceholder.typicode.com/users")
                .Select(x => {
                    x.Posts = GetPosts(x.Id);
                    return x;
                });
            foreach (var item in users) {
                yield return item;
            }
        }
    }
}
