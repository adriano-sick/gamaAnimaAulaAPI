using Entities;
using gamaAnimaAulasAPI.Controllers;
using Moq;
using NUnit.Framework;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GamaAnimaAulaApiTest
{
    public class RepositoryTests
    {
        AulaRepository _aulaRepository;
        AulasController _aulasController;
        AulaContext _aulaContext;
        private Mock<Aula> aulaMock;

        [SetUp]
        public void Setup()
        {
            _aulaRepository = new AulaRepository();
            _aulasController = new AulasController();
        }

        [Test]
        public void AulaEntityCreation()
        {
            aulaMock = new Mock<Aula>();
            aulaMock.Object.Id = 1;
            aulaMock.Object.Content = "content-test";
            aulaMock.Object.Date = "date-test";
            aulaMock.Object.Subject = "subject-test";
            aulaMock.Object.Teacher = "teacher-test";
            aulaMock.Object.Duration = "duration-test";
            aulaMock.Object.Link = "link-test";

            Assert.IsNotNull(aulaMock);
        }

        [Test]
        public void GetAulas_NotNull()
        {
            Assert.NotNull(_aulaRepository.GetAulas());
        }

        [Test]
        [TestCase(1)]
        [TestCase(0, ExpectedResult = null)]
        public Aula GetAula_ReturnAulaObj(int id)
        {
            //Assert.NotNull(_aulaRepository.GetAulaById(id));
            return _aulaRepository.GetAulaById(id);
        }

        //[Test]
        //public void Get

    }
}