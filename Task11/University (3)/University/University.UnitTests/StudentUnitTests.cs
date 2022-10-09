using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University;
using NUnit.Framework;

namespace University.UnitTests
{
    [TestFixture]
    public class StudentUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var ulyana = CreateTestStudent();

            Assert.AreEqual("Ульяна", ulyana.Name);
            Assert.AreEqual("Советова", ulyana.Surname);
            Assert.AreEqual(4443, ulyana.Number);
        }

        [Test]
        public void ToStringTest()
        {
            var ulyana = CreateTestStudent();
            Assert.AreEqual("Ульяна Советова", ulyana.ToString());
        }

        [Test]
        public void GetInfoTest()
        {
            var ulyana = CreateTestStudent();

            ulyana.Group = 116004;
            ulyana.Institute = "УГИ";
            ulyana.Type = StudyType.Bachelor;
            var info = ulyana.GetInfo();

            Assert.AreEqual(2, info.Length);
            Assert.AreEqual("Ульяна Советова", info[0]);
            Assert.AreEqual($"Номер зачётной книжки: 4443. Группа: 116004. Институт: УГИ. Направление обучения: бакалавриат.", info[1]);
        }

        private Student CreateTestStudent()
        {
            return new Student("Ульяна", "Советова", 4443);
        }
    }
}
