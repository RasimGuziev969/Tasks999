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
    public class StudentExUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var ulyana = CreateTestStudentEx();

            Assert.AreEqual("Ульяна", ulyana.Name);
            Assert.AreEqual("Советова", ulyana.Surname);
            Assert.AreEqual(3334, ulyana.Number);
            Assert.AreEqual("Детский лагерь \"Совёнок\"", ulyana.Workplace);
            Assert.AreEqual("Вожатая", ulyana.Job);
        }

        [Test]
        public void ToStringTest()
        {
            var ulyana = CreateTestStudentEx();
            Assert.AreEqual("Ульяна Советова", ulyana.ToString());
        }

        [Test]
        public void GetInfoTest()
        {
            var ulyana = CreateTestStudentEx();

            ulyana.Group = 116004;
            ulyana.Institute = "УГИ";
            ulyana.Type = StudyType.Bachelor;
            var info = ulyana.GetInfo();

            Assert.AreEqual(2, info.Length);
            Assert.AreEqual("Ульяна Советова", info[0]);
            Assert.AreEqual($"Номер зачётной книжки: 4443. Группа: 116004. Институт: УГИ. Направление обучения: бакалавриат.\nМесто работы: Детский лагерь \"Совёнок\". Должность: Вожатая", info[1]);
        }

        private StudentEx CreateTestStudentEx()
        {
            return new StudentEx("Ульяна", "Советова", 3334, "Детский лагерь \"Совёнок\"", "Вожатая");
        }
    }
}
