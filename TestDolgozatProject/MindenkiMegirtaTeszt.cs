using DolgozatProject;

namespace TestDolgozatProject
{
    internal class MindenkiMegirtaTeszt
    {
        Dolgozat dolgozat;

        [SetUp]
        public void Setup()
        {
            dolgozat = new Dolgozat();
        }

        [Test]
        public void MindenkiMegirtaJolAdVisszaErteketUresListanal()
        {
            Assert.That(dolgozat.MindenkiMegirta, Is.EqualTo(false));
        }

        [Test]
        public void MindenkiMegirtaJolAdVisszaErteketEgyElemesLista()
        {
            dolgozat.Pontfelvesz(5);
            Assert.That(dolgozat.MindenkiMegirta, Is.EqualTo(true));
        }

        [Test]
        public void MindenkiMegirtaJolAdVisszaErteketTobbElemesLista()
        {
            dolgozat.Pontfelvesz(5);
            dolgozat.Pontfelvesz(2);
            dolgozat.Pontfelvesz(26);
            Assert.That(dolgozat.MindenkiMegirta, Is.EqualTo(true));
        }

        [Test]
        public void MindenkiMegirtaJolAdVisszaErteketEgyElemesListaFalse()
        {
            dolgozat.Pontfelvesz(-1);
            Assert.That(dolgozat.MindenkiMegirta, Is.EqualTo(false));
        }

        [Test]
        public void MindenkiMegirtaJolAdVisszaErteketTobbElemesListaFalse()
        {
            dolgozat.Pontfelvesz(-1);
            dolgozat.Pontfelvesz(-1);
            dolgozat.Pontfelvesz(26);
            Assert.That(dolgozat.MindenkiMegirta, Is.EqualTo(false));
        }

        [Test]
        public void MindenkiMegirtaJolAdVisszaErteketTobbElemesListaCsakFalse()
        {
            dolgozat.Pontfelvesz(-1);
            dolgozat.Pontfelvesz(-1);
            dolgozat.Pontfelvesz(-1);
            Assert.That(dolgozat.MindenkiMegirta, Is.EqualTo(false));
        }
    }
}
