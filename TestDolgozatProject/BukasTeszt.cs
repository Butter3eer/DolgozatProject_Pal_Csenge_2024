using DolgozatProject;

namespace TestDolgozatProject
{
    public class BukasTeszt
    {
        Dolgozat dolgozat;

        [SetUp]
        public void Setup()
        {
            dolgozat = new Dolgozat();
        }

        [Test]
        public void BukasJolAdVisszaUresListanal()
        {
            Assert.That(dolgozat.Bukas, Is.EqualTo(0));
        }

        [Test]
        public void BukasJolAdVisszaEgyElemesListanalAmiNemBukas()
        {
            dolgozat.Pontfelvesz(80);
            Assert.That(dolgozat.Bukas, Is.EqualTo(0));
        }

        [Test]
        public void BukasJolAdVisszaEgyElemesListanalAmiNemBukasFelsoHatarFelett()
        {
            dolgozat.Pontfelvesz(50);
            Assert.That(dolgozat.Bukas, Is.EqualTo(0));
        }

        [Test]
        public void BukasJolAdVisszaEgyElemesListanalAmiBukasFelsoHatarral()
        {
            dolgozat.Pontfelvesz(49);
            Assert.That(dolgozat.Bukas, Is.EqualTo(1));
        }

        [Test]
        public void BukasJolAdVisszaEgyElemesListanalAmiBukas()
        {
            dolgozat.Pontfelvesz(4);
            Assert.That(dolgozat.Bukas, Is.EqualTo(1));
        }

        [Test]
        public void BukasJolAdVisszaTobbElemesListanalAmiNemBukasFelsoHatarFelett()
        {
            dolgozat.Pontfelvesz(80);
            dolgozat.Pontfelvesz(51);
            dolgozat.Pontfelvesz(50);
            Assert.That(dolgozat.Bukas, Is.EqualTo(0));
        }

        [Test]
        public void BukasJolAdVisszaTobbElemesListanalAmiNemBukas()
        {
            dolgozat.Pontfelvesz(80);
            dolgozat.Pontfelvesz(67);
            dolgozat.Pontfelvesz(100);
            Assert.That(dolgozat.Bukas, Is.EqualTo(0));
        }

        [Test]
        public void BukasJolAdVisszaTobbElemesListanalAmiBukas()
        {
            dolgozat.Pontfelvesz(3);
            dolgozat.Pontfelvesz(4);
            dolgozat.Pontfelvesz(6);
            Assert.That(dolgozat.Bukas, Is.EqualTo(3));
        }

        [Test]
        public void BukasJolAdVisszaTobbElemesListanalAmibenVanBukas()
        {
            dolgozat.Pontfelvesz(3);
            dolgozat.Pontfelvesz(87);
            dolgozat.Pontfelvesz(99);
            Assert.That(dolgozat.Bukas, Is.EqualTo(1));
        }
    }
}