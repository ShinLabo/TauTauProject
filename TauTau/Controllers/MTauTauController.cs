using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TauTau.Models;
using System.Web.Configuration;
using System.Collections.Specialized;

namespace TauTau.Controllers
{
    public class MTauTauController : Controller
    {
        private MTauTauContext db = new MTauTauContext();

        /* メインビュー：タイムライン */
        public ActionResult Index()
        {
            return View(db.MTauTaus.ToList());
        }
        /* クリエイトビュー：エディット */
        public ActionResult Create()
        {
            return View();
        }
        /* クリエイトビュー：投稿機能 */
        [HttpPost]
        public ActionResult Create([Bind(Include = "Main_View_TimeLine")] MTauTau mTauTau)
        {
                if (ModelState.IsValid)
                {
                    db.MTauTaus.Add(mTauTau);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View();
        }
        /* 歌詞ビュー：ミュージックページ */
        [HttpPost]
        public ActionResult Post_MusicPage(string Music_Stock1, string Music_Stock2, string Music_Stock3, string Music_Stock4, string Music_Stock5
            , string Music_Stock6, string Music_Stock7, string Music_Stock8)
        {
            ViewData["PostData1"] = Music_Stock1;
            ViewData["PostData2"] = Music_Stock2;
            ViewData["PostData3"] = Music_Stock3;
            ViewData["PostData4"] = Music_Stock4;
            ViewData["PostData5"] = Music_Stock5;
            ViewData["PostData6"] = Music_Stock6;
            ViewData["PostData7"] = Music_Stock7;
            ViewData["PostData8"] = Music_Stock8;

            int FontLengs1 = 0;
            int FontLengs2 = 0;
            int FontLengs3 = 0;
            int FontLengs4 = 0;
            int FontLengs5 = 0;
            int FontLengs6 = 0;
            int FontLengs7 = 0;
            int FontLengs8 = 0;

            if (Music_Stock1 != null)
            {
                FontLengs1 = Music_Stock1.Length;
                Random r = new System.Random();

                for (int i = 0; i < FontLengs1; i++)
                {
                    int RNo = r.Next(10);
                    switch (RNo)
                    {
                        case 1:
                            ViewData["OnpData1"] += ("♪");
                            break;
                        case 2:
                            ViewData["OnpData1"] += ("#");
                            break;
                        case 3:
                            ViewData["OnpData1"] += ("♩");
                            break;
                        case 4:
                            ViewData["OnpData1"] += ("v");
                            break;
                        case 5:
                            ViewData["OnpData1"] += ("♫");
                            break;
                        case 6:
                            ViewData["OnpData1"] += ("♪");
                            break;
                        case 7:
                            ViewData["OnpData1"] += ("θ");
                            break;
                        case 8:
                            ViewData["OnpData1"] += ("♩");
                            break;
                        case 9:
                            ViewData["OnpData1"] += ("Φ");
                            break;
                        case 10:
                            ViewData["OnpData1"] += ("♫");
                            break;
                        default:
                            ViewData["OnpData1"] += ("♫");
                            break;
                    }
                }
            }
            else
            {
            }
            if (Music_Stock2 != null)
            {
                FontLengs2 = Music_Stock2.Length;
                Random r = new System.Random();
                for (int i = 0; i < FontLengs2; i++)
                {
                    int RNo = r.Next(10);
                    switch (RNo)
                    {
                        case 1:
                            ViewData["OnpData2"] += ("♪");
                            break;
                        case 2:
                            ViewData["OnpData2"] += ("#");
                            break;
                        case 3:
                            ViewData["OnpData2"] += ("♩");
                            break;
                        case 4:
                            ViewData["OnpData2"] += ("v");
                            break;
                        case 5:
                            ViewData["OnpData2"] += ("♫");
                            break;
                        case 6:
                            ViewData["OnpData2"] += ("♪");
                            break;
                        case 7:
                            ViewData["OnpData2"] += ("θ");
                            break;
                        case 8:
                            ViewData["OnpData2"] += ("♩");
                            break;
                        case 9:
                            ViewData["OnpData2"] += ("Φ");
                            break;
                        case 10:
                            ViewData["OnpData2"] += ("♫");
                            break;
                        default:
                            ViewData["OnpData2"] += ("♫");
                            break;
                    }
                }
            }
            else
            {
            }
            if (Music_Stock3 != null)
            {
                FontLengs3 = Music_Stock3.Length;
                Random r = new System.Random();
                for (int i = 0; i < FontLengs3; i++)
                {
                    int RNo = r.Next(10);
                    switch (RNo)
                    {
                        case 1:
                            ViewData["OnpData3"] += ("♪");
                            break;
                        case 2:
                            ViewData["OnpData3"] += ("#");
                            break;
                        case 3:
                            ViewData["OnpData3"] += ("♩");
                            break;
                        case 4:
                            ViewData["OnpData3"] += ("v");
                            break;
                        case 5:
                            ViewData["OnpData3"] += ("♫");
                            break;
                        case 6:
                            ViewData["OnpData3"] += ("♪");
                            break;
                        case 7:
                            ViewData["OnpData3"] += ("θ");
                            break;
                        case 8:
                            ViewData["OnpData3"] += ("♩");
                            break;
                        case 9:
                            ViewData["OnpData3"] += ("Φ");
                            break;
                        case 10:
                            ViewData["OnpData3"] += ("♫");
                            break;
                        default:
                            ViewData["OnpData3"] += ("♫");
                            break;
                    }
                }
            }
            else
            {
            }
            if (Music_Stock4 != null)
            {
                FontLengs4 = Music_Stock4.Length;
                Random r = new System.Random();
                for (int i = 0; i < FontLengs4; i++)
                {
                    int RNo = r.Next(10);
                    switch (RNo)
                    {
                        case 1:
                            ViewData["OnpData4"] += ("♪");
                            break;
                        case 2:
                            ViewData["OnpData4"] += ("#");
                            break;
                        case 3:
                            ViewData["OnpData4"] += ("♩");
                            break;
                        case 4:
                            ViewData["OnpData4"] += ("v");
                            break;
                        case 5:
                            ViewData["OnpData4"] += ("♫");
                            break;
                        case 6:
                            ViewData["OnpData4"] += ("♪");
                            break;
                        case 7:
                            ViewData["OnpData4"] += ("θ");
                            break;
                        case 8:
                            ViewData["OnpData4"] += ("♩");
                            break;
                        case 9:
                            ViewData["OnpData4"] += ("Φ");
                            break;
                        case 10:
                            ViewData["OnpData4"] += ("♫");
                            break;
                        default:
                            ViewData["OnpData4"] += ("♫");
                            break;
                    }
                }
            }
            else
            {
            }
            if (Music_Stock5 != null)
            {
                FontLengs5 = Music_Stock5.Length;
                Random r = new System.Random();
                for (int i = 0; i < FontLengs5; i++)
                {
                    int RNo = r.Next(10);
                    switch (RNo)
                    {
                        case 1:
                            ViewData["OnpData5"] += ("♪");
                            break;
                        case 2:
                            ViewData["OnpData5"] += ("#");
                            break;
                        case 3:
                            ViewData["OnpData5"] += ("♩");
                            break;
                        case 4:
                            ViewData["OnpData5"] += ("v");
                            break;
                        case 5:
                            ViewData["OnpData5"] += ("♫");
                            break;
                        case 6:
                            ViewData["OnpData5"] += ("♪");
                            break;
                        case 7:
                            ViewData["OnpData5"] += ("θ");
                            break;
                        case 8:
                            ViewData["OnpData5"] += ("♩");
                            break;
                        case 9:
                            ViewData["OnpData5"] += ("Φ");
                            break;
                        case 10:
                            ViewData["OnpData5"] += ("♫");
                            break;
                        default:
                            ViewData["OnpData5"] += ("♫");
                            break;
                    }
                }
            }
            else
            {
            }
            if (Music_Stock4 != null)
            {
                FontLengs6 = Music_Stock6.Length;
                Random r = new System.Random();
                for (int i = 0; i < FontLengs6; i++)
                {
                    int RNo = r.Next(10);
                    switch (RNo)
                    {
                        case 1:
                            ViewData["OnpData6"] += ("♪");
                            break;
                        case 2:
                            ViewData["OnpData6"] += ("#");
                            break;
                        case 3:
                            ViewData["OnpData6"] += ("♩");
                            break;
                        case 4:
                            ViewData["OnpData6"] += ("v");
                            break;
                        case 5:
                            ViewData["OnpData6"] += ("♫");
                            break;
                        case 6:
                            ViewData["OnpData6"] += ("♪");
                            break;
                        case 7:
                            ViewData["OnpData6"] += ("θ");
                            break;
                        case 8:
                            ViewData["OnpData6"] += ("♩");
                            break;
                        case 9:
                            ViewData["OnpData6"] += ("Φ");
                            break;
                        case 10:
                            ViewData["OnpData6"] += ("♫");
                            break;
                        default:
                            ViewData["OnpData6"] += ("♫");
                            break;
                    }
                }
            }
            else
            {
            }
            if (Music_Stock7 != null)
            {
                FontLengs7 = Music_Stock7.Length;
                Random r = new System.Random();
                for (int i = 0; i < FontLengs7; i++)
                {
                    int RNo = r.Next(10);
                    switch (RNo)
                    {
                        case 1:
                            ViewData["OnpData7"] += ("♪");
                            break;
                        case 2:
                            ViewData["OnpData7"] += ("#");
                            break;
                        case 3:
                            ViewData["OnpData7"] += ("♩");
                            break;
                        case 4:
                            ViewData["OnpData7"] += ("v");
                            break;
                        case 5:
                            ViewData["OnpData7"] += ("♫");
                            break;
                        case 6:
                            ViewData["OnpData7"] += ("♪");
                            break;
                        case 7:
                            ViewData["OnpData7"] += ("θ");
                            break;
                        case 8:
                            ViewData["OnpData7"] += ("♩");
                            break;
                        case 9:
                            ViewData["OnpData7"] += ("Φ");
                            break;
                        case 10:
                            ViewData["OnpData7"] += ("♫");
                            break;
                        default:
                            ViewData["OnpData7"] += ("♫");
                            break;
                    }
                }
            }
            else
            {
            }
            if (Music_Stock4 != null)
            {
                FontLengs8 = Music_Stock8.Length;
                Random r = new System.Random();
                for (int i = 0; i < FontLengs8; i++)
                {
                    int RNo = r.Next(10);
                    switch (RNo)
                    {
                        case 1:
                            ViewData["OnpData8"] += ("♪");
                            break;
                        case 2:
                            ViewData["OnpData8"] += ("#");
                            break;
                        case 3:
                            ViewData["OnpData8"] += ("♩");
                            break;
                        case 4:
                            ViewData["OnpData8"] += ("v");
                            break;
                        case 5:
                            ViewData["OnpData8"] += ("♫");
                            break;
                        case 6:
                            ViewData["OnpData8"] += ("♪");
                            break;
                        case 7:
                            ViewData["OnpData8"] += ("θ");
                            break;
                        case 8:
                            ViewData["OnpData8"] += ("♩");
                            break;
                        case 9:
                            ViewData["OnpData8"] += ("Φ");
                            break;
                        case 10:
                            ViewData["OnpData8"] += ("♫");
                            break;
                        default:
                            ViewData["OnpData8"] += ("♫");
                            break;
                    }
                }
                return View();
            }
            else
            {
                return View();
            }
        }
    }
}