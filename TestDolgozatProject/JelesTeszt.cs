using DolgozatProject;

namespace TestDolgozatProject
{
    public class JelesTeszt
    {
        Dolgozat dolgozat;

        [SetUp]
        public void Setup()
        {
            dolgozat = new Dolgozat();
        }

        [Test]
        public void JelesJolAdVisszaUresListanal()
        {
            Assert.That(dolgozat.Jeles, Is.EqualTo(0));
        }

        [Test]
        public void JelesJolAdVisszaEgyElemesListanalAmiNemJeles()
        {
            dolgozat.Pontfelvesz(50);
            Assert.That(dolgozat.Jeles, Is.EqualTo(0));
        }

        [Test]
        public void JelesJolAdVisszaEgyElemesListanalAmiJelesAlsoHatarral()
        {
            dolgozat.Pontfelvesz(81);
            Assert.That(dolgozat.Jeles, Is.EqualTo(1));
        }

        [Test]
        public void JelesJolAdVisszaEgyElemesListanalAmiNemJelesAlsoHatarAlatt()
        {
            dolgozat.Pontfelvesz(80);
            Assert.That(dolgozat.Jeles, Is.EqualTo(0));
        }

        [Test]
        public void JelesJolAdVisszaEgyElemesListanalAmiJeles()
        {
            dolgozat.Pontfelvesz(85);
            Assert.That(dolgozat.Jeles, Is.EqualTo(1));
        }

        [Test]
        public void JelesJolAdVisszaTobbElemesListanalAmiNemJelesAlsoHatarAlatt()
        {
            dolgozat.Pontfelvesz(80);
            dolgozat.Pontfelvesz(51);
            dolgozat.Pontfelvesz(50);
            Assert.That(dolgozat.Jeles, Is.EqualTo(0));
        }

        [Test]
        public void JelesJolAdVisszaTobbElemesListanalAmiNemJeles()
        {
            dolgozat.Pontfelvesz(80);
            dolgozat.Pontfelvesz(67);
            dolgozat.Pontfelvesz(44);
            Assert.That(dolgozat.Jeles, Is.EqualTo(0));
        }

        [Test]
        public void JelesJolAdVisszaTobbElemesListanalAmiJeles()
        {
            dolgozat.Pontfelvesz(83);
            dolgozat.Pontfelvesz(84);
            dolgozat.Pontfelvesz(86);
            Assert.That(dolgozat.Jeles, Is.EqualTo(3));
        }

        [Test]
        public void JelesJolAdVisszaTobbElemesListanalAmibenVanJeles()
        {
            dolgozat.Pontfelvesz(3);
            dolgozat.Pontfelvesz(55);
            dolgozat.Pontfelvesz(99);
            Assert.That(dolgozat.Jeles, Is.EqualTo(1));
        }
    }
}