using DolgozatProject;

namespace TestDolgozatProject
{
    internal class PontFelveszEsPontokListaTeszt
    {
        Dolgozat dolgozat;

        [SetUp]
        public void Setup()
        {
            dolgozat = new Dolgozat();
        }

        [Test]
        public void PontokListaFelveszErteket()
        {
            dolgozat.Pontfelvesz(5);
            Assert.That(dolgozat.Pontok.Count, Is.Not.EqualTo(0));
        }

        [Test]
        public void PontokListaFelveszTobbErteket()
        {
            dolgozat.Pontfelvesz(5);
            dolgozat.Pontfelvesz(2);
            dolgozat.Pontfelvesz(26);
            Assert.That(dolgozat.Pontok.Count, Is.EqualTo(3));
        }

        [Test]
        public void PontokListaFelvesziAMegfeleloAdatot()
        {
            dolgozat.Pontfelvesz(10);
            Assert.That(dolgozat.Pontok.Contains(10), Is.EqualTo(true));
        }

        [Test]
        public void PontokListaFelvesziAMegfeleloAdatokat()
        {
            dolgozat.Pontfelvesz(10);
            dolgozat.Pontfelvesz(15);
            Assert.That(dolgozat.Pontok.Contains(10), Is.EqualTo(true));
            Assert.That(dolgozat.Pontok.Contains(15), Is.EqualTo(true));
            Assert.That(dolgozat.Pontok.Contains(5), Is.Not.EqualTo(true));
        }

        [Test]
        public void PontFelveszErrortDobKissebbPontnal()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => { dolgozat.Pontfelvesz(-5); });
        }

        [Test]
        public void PontFelveszErrortDobNagyobbPontnal()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => { dolgozat.Pontfelvesz(105); });
        }
    }
}
