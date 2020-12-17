using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.Tests
{
    [TestClass]
    public class AlbumTests //: IDisposable
    {
        // public void Dispose()
        // {
        //     Category.ClearAll();
        // }

        [TestMethod]
        public void AlbumConstructor_CreateInstanceOfAlbum_Album()
        {
            Album newAlbum = new Album("test album");
            Assert.AreEqual(typeof(Album), newAlbum.GetType());
        }

    }
}