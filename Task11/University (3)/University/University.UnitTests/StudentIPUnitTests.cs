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
    public class StudentIPUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var ulyana = CreateTestStudentIP();

            Assert.AreEqual("Ульяна", ulyana.Name);
            Assert.AreEqual("Советова", ulyana.Surname);
            Assert.AreEqual(3334, ulyana.Number);
            Assert.AreEqual(264, ulyana.Exam);
            Assert.AreEqual(82.7, ulyana.GPA);
        }

        [Test]
        public void ToStringTest()
        {
            var ulyana = CreateTestStudentIP();
            Assert.AreEqual("Ульяна Советова", ulyana.ToString());
        }

        [Test]
        public void GetInfoTest()
        {
            var ulyana = CreateTestStudentIP();

            ulyana.Group = 116004;
            ulyana.Institute = "УГИ";
            ulyana.Type = StudyType.Bachelor;
            var info = ulyana.GetInfo();

            Assert.AreEqual(2, info.Length);
            Assert.AreEqual("Ульяна Советова", info[0]);
            Assert.AreEqual($"Номер зачётной книжки: 4443. Группа: 116004. Институт: УГИ. Направление обучения: бакалавриат.\nБалл ЕГЭ: 264. Средний балл в БРС: 82,7", info[1]);
        }

        private StudentIP CreateTestStudentIP()
        {
            return new StudentIP("Ульяна", "Советова", 3334, 264, 82.7);
        }
    }
}
