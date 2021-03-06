﻿/*
 * This file is part of alphaTab.
 * Copyright (c) 2014, Daniel Kuschny and Contributors, All rights reserved.
 * 
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3.0 of the License, or at your option any later version.
 * 
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 * 
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library.
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlphaTab.Test.Importer
{
    [TestClass]
    public class Gp4ImporterTest : GpImporterTestBase
    {
        [TestMethod]
        public void TestScoreInfo()
        {
            var reader = PrepareImporterWithFile("Test01.gp4");
            var score = reader.ReadScore();

            Assert.AreEqual("Title", score.Title);
            Assert.AreEqual("Subtitle", score.SubTitle);
            Assert.AreEqual("Artist", score.Artist);
            Assert.AreEqual("Album", score.Album);
            Assert.AreEqual("Music", score.Words); // no words in gp4
            Assert.AreEqual("Music", score.Music);
            Assert.AreEqual("Copyright", score.Copyright);
            Assert.AreEqual("Tab", score.Tab);
            Assert.AreEqual("Instructions", score.Instructions);
            Assert.AreEqual("Notice1\r\nNotice2", score.Notices);
            Assert.AreEqual(5, score.MasterBars.Count);
            Assert.AreEqual(1, score.Tracks.Count);
            Assert.AreEqual("Track 1", score.Tracks[0].Name);
        }

        [TestMethod]
        public void TestNotes()
        {
            var reader = PrepareImporterWithFile("Test02.gp4");
            var score = reader.ReadScore();
            CheckTest02Score(score);
        }

        [TestMethod]
        public void TestTimeSignatures()
        {
            var reader = PrepareImporterWithFile("Test03.gp4");
            var score = reader.ReadScore();

            CheckTest03Score(score);
        }

        [TestMethod]
        public void TestDead()
        {
            var reader = PrepareImporterWithFile("TestDead.gp4");
            var score = reader.ReadScore();
            CheckDead(score);
        }

        [TestMethod]
        public void TestGrace()
        {
            var reader = PrepareImporterWithFile("TestGrace.gp4");
            var score = reader.ReadScore();
            CheckGrace(score);
        }

        [TestMethod]
        public void TestAccentuation()
        {
            var reader = PrepareImporterWithFile("TestAccentuations.gp4");
            var score = reader.ReadScore();
            CheckAccentuation(score, false);
        }

        [TestMethod]
        public void TestHarmonics()
        {
            var reader = PrepareImporterWithFile("TestHarmonics.gp4");
            var score = reader.ReadScore();
            CheckHarmonics(score);
        }

        [TestMethod]
        public void TestHammer()
        {
            var reader = PrepareImporterWithFile("TestHammer.gp4");
            var score = reader.ReadScore();
            CheckHammer(score);
        }

        [TestMethod]
        public void TestBend()
        {
            var reader = PrepareImporterWithFile("TestBends.gp4");
            var score = reader.ReadScore();
            CheckBend(score);
        }

        [TestMethod]
        public void TestTremolo()
        {
            var reader = PrepareImporterWithFile("TestTremolo.gp4");
            var score = reader.ReadScore();
            CheckTremolo(score);
        }

        [TestMethod]
        public void TestSlides()
        {
            var reader = PrepareImporterWithFile("TestSlides.gp4");
            var score = reader.ReadScore();
            CheckSlides(score);
        }

        [TestMethod]
        public void TestVibrato()
        {
            var reader = PrepareImporterWithFile("TestVibrato.gp4");
            var score = reader.ReadScore();
            CheckVibrato(score, true);
        }

        [TestMethod]
        public void TestTrills()
        {
            var reader = PrepareImporterWithFile("TestTrills.gp4");
            var score = reader.ReadScore();
            CheckTrills(score);
        }

        [TestMethod]
        public void TestOtherEffects()
        {
            var reader = PrepareImporterWithFile("TestOtherEffects.gp4");
            var score = reader.ReadScore();
            CheckOtherEffects(score);
        }

        [TestMethod]
        public void TestFingering()
        {
            var reader = PrepareImporterWithFile("TestFingering.gp4");
            var score = reader.ReadScore();
            CheckFingering(score);
        }

        [TestMethod]
        public void TestStroke()
        {
            var reader = PrepareImporterWithFile("TestStrokes.gp4");
            var score = reader.ReadScore();
            CheckStroke(score);
        }

        [TestMethod]
        public void TestTuplets()
        {
            var reader = PrepareImporterWithFile("TestTuplets.gp4");
            var score = reader.ReadScore();
            CheckTuplets(score);
        }

        [TestMethod]
        public void TestRanges()
        {
            var reader = PrepareImporterWithFile("TestRanges.gp4");
            var score = reader.ReadScore();
            CheckRanges(score);
        }

        [TestMethod]
        public void TestEffects()
        {
            var reader = PrepareImporterWithFile("Effects.gp4");
            var score = reader.ReadScore();
            CheckEffects(score);
        }

        [TestMethod]
        public void TestStrings()
        {
            var reader = PrepareImporterWithFile("TestStrings.gp4");
            var score = reader.ReadScore();
            CheckStrings(score);
        }

    }
}
