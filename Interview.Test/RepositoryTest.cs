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

        [Test]
		public void AddTest_WhenSuccessful()
        {
            var _person = new Person();
            _person.Name = "New";
            _person.Id = 22;
            _person.Age = 26;
            var _repository = new Repository<Person>();
            _repository.Add(_person);
            _repository.Add(_person);
            Assert.IsNotNull(_person.Id);
        }
		
    }
}