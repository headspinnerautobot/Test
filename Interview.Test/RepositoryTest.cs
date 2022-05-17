using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using System.Threading.Tasks;
using Interview.Core;
using NUnit.Framework;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Interview.Test
{
    
    public class RepositoryTest
    {
        //[TestMethod]
        //public void TestSetup()
        //{
        //    var _person = new Person();
        //    _person.Name = "New";
        //    _person.Id = 22;
        //    _person.Age = 26;
        //    var _repository = new Repository<Person>();
        //    _repository.Add(_person);
        //}

      
        private readonly Person _person = new Person();

        [Test]
		public void AddTest_WhenSuccessful()
        {
            List<Person> personList = new List<Person>();
            var person = new Person { };
            person.Name = "New";
            person.Id = 22;
            person.Age = 26;
            var _repository = new Repository<Person>(personList);
            _repository.Add(person);
            Assert.AreEqual(personList.Count, 1);
        }

        [Test]
        public void GetAll()
        {
            var persons = new List<Person>
            { new Person{Name="Mayank",Id=1,Age=26},
              new Person{Name="Ptern",Id=2,Age=23},
              new Person{Name="3rd", Id=3, Age=19}
            };

            var _repository = new Repository<Person>(persons);
            var results= _repository.FindAll(p =>p.Age >=20);
            Assert.IsEmpty(results.Where(p=>p.Age<20));

        }

    }
}