using DolgozatProject;

namespace TestDolgozatProject
{
    internal class ElegsegesTeszt
    {
        Dolgozat dolgozat;

        [SetUp]
        public void Setup()
        {
            dolgozat = new Dolgozat();
        }

        [Test]
        public void ElegsegesJolAdVisszaUresListanal()
        {
            Assert.That(dolgozat.Elegseges, Is.EqualTo(0));
        }

        [Test]
        public void ElegsegesJolAdVisszaEgyElemesListanalAmiNemElegseges()
        {
            dolgozat.Pontfelvesz(80);
            Assert.That(dolgozat.Elegseges, Is.EqualTo(0));
        }

        [Test]
        public void ElegsegesJolAdVisszaEgyElemesListanalAmiElegseges()
        {
            dolgozat.Pontfelvesz(55);
            Assert.That(dolgozat.Elegseges, Is.EqualTo(1));
        }

        [Test]
        public void ElegsegesJolAdVisszaEgyElemesListanalAmiElegsegesAlsoHatarral()
        {
            dolgozat.Pontfelvesz(50);
            Assert.That(dolgozat.Elegseges, Is.EqualTo(1));
        }

        [Test]
        public void ElegsegesJolAdVisszaEgyElemesListanalAmiNemElegsegesAlsoHatarAlatt()
        {
            dolgozat.Pontfelvesz(49);
            Assert.That(dolgozat.Elegseges, Is.EqualTo(0));
        }

        [Test]
        public void ElegsegesJolAdVisszaEgyElemesListanalAmiElegsegesFlsoHatarral()
        {
            dolgozat.Pontfelvesz(60);
            Assert.That(dolgozat.Elegseges, Is.EqualTo(1));
        }

        [Test]
        public void ElegsegesJolAdVisszaEgyElemesListanalAmiNemElegsegesFlsoHatarFelett()
        {
            dolgozat.Pontfelvesz(61);
            Assert.That(dolgozat.Elegseges, Is.EqualTo(0));
        }

        [Test]
        public void ElegsegesJolAdVisszaTobbElemesListanalAmiNemElegseges()
        {
            dolgozat.Pontfelvesz(80);
            dolgozat.Pontfelvesz(89);
            dolgozat.Pontfelvesz(34);
            Assert.That(dolgozat.Elegseges, Is.EqualTo(0));
        }

        [Test]
        public void ElegsegesJolAdVisszaTobbElemesListanalAmibenVanElegseges()
        {
            dolgozat.Pontfelvesz(80);
            dolgozat.Pontfelvesz(55);
            dolgozat.Pontfelvesz(34);
            Assert.That(dolgozat.Elegseges, Is.EqualTo(1));
        }

        [Test]
        public void ElegsegesJolAdVisszaTobbElemesListanalAmiElegseges()
        {
            dolgozat.Pontfelvesz(50);
            dolgozat.Pontfelvesz(55);
            dolgozat.Pontfelvesz(60);
            Assert.That(dolgozat.Elegseges, Is.EqualTo(3));
        }

        [Test]
        public void ElegsegesJolAdVisszaTobbElemesListanalAmibenVanElegsegesAlsoHatarral()
        {
            dolgozat.Pontfelvesz(80);
            dolgozat.Pontfelvesz(50);
            dolgozat.Pontfelvesz(49);
            Assert.That(dolgozat.Elegseges, Is.EqualTo(1));
        }

        [Test]
        public void ElegsegesJolAdVisszaTobbElemesListanalAmibenVanElegsegesFelsoHatarral()
        {
            dolgozat.Pontfelvesz(80);
            dolgozat.Pontfelvesz(60);
            dolgozat.Pontfelvesz(61);
            Assert.That(dolgozat.Elegseges, Is.EqualTo(1));
        }
    }
}
