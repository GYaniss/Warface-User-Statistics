using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Collections;

namespace Warface
{
   
    /// <summary>
    /// Сводное описание для DataConvert
    /// </summary>
    public class Info
    {
        UserInfo JUser = null;
        Hashtable KeyUser = new Hashtable();
        /// <summary>
        /// Наименование класса
        /// </summary>
        /// <param name="UC"></param>
        /// <returns></returns>
        string ClassName(string UC)
        {
            string R = "";
            switch (UC)
            {
                case "Engineer": R = "Инженер"; break;
                case "Recon": R = "Cнайпер"; break;
                case "Rifleman": R = "Штурмовик"; break;
                case "Medic": R = "Медик"; break;
            }
            return R;
        }
        /// <summary>
        /// Картинка класса
        /// </summary>
        /// <param name="idRank"></param>
        /// <returns></returns>
        string RankImage(int idRank)
        {
            string R = "<img alt='" + RankName(idRank) + "' src='/Images/rank/Rank" + idRank.ToString() + ".png' height='40'/>";
            return R;
        }

        /// <summary>
        /// Наменование ранга
        /// </summary>
        /// <param name="idRank"></param>
        /// <returns></returns>
        string RankName(int idRank)
        {
            string R = "";
            switch (idRank)
            {
                case 1: R = "Новобранец"; break;
                case 2: R = "Младший рекрут"; break;
                case 3: R = "Рекрут"; break;
                case 4: R = "Старший рекрут"; break;
                case 5: R = "Рекрут 1 класса"; break;
                case 6: R = "Солдат"; break;
                case 7: R = "Рядовой рекрут"; break;
                case 8: R = "Рядовой 2 класса"; break;
                case 9: R = "Рядовой"; break;
                case 10: R = "Рядовой 1 класса"; break;
                case 11: R = "Специалист"; break;
                case 12: R = "Старший специалист"; break;
                case 13: R = "Техник"; break;
                case 14: R = "Специалист 1 класса"; break;
                case 15: R = "Разведчик"; break;
                case 16: R = "Младший капрал"; break;
                case 17: R = "Капрал"; break;
                case 18: R = "Командир звена"; break;
                case 19: R = "Сержант 3 класса"; break;
                case 20: R = "Сержант 2 класса"; break;
                case 21: R = "Сержант"; break;
                case 22: R = "Штаб-сержант"; break;
                case 23: R = "Сержант 1 класса"; break;
                case 24: R = "Комендор-сержант"; break;
                case 25: R = "Мастер-сержант"; break;
                case 26: R = "Первый сержант"; break;
                case 27: R = "Команд-сержант"; break;
                case 28: R = "Мастер-комендор-сержант"; break;
                case 29: R = "Сержант-майор"; break;
                case 30: R = "Команд-сержант-майор"; break;
                case 31: R = "Младший уорент-офицер"; break;
                case 32: R = "Уорент-офицер"; break;
                case 33: R = "Старший уорент-офицер"; break;
                case 34: R = "Старший уорент-офицер 1 класc"; break;
                case 35: R = "Мастер уорент-офицер"; break;
                case 36: R = "Квартирмейстер"; break;
                case 37: R = "Младший офицер"; break;
                case 38: R = "Старший офицер"; break;
                case 39: R = "Младший лейтенант"; break;
                case 40: R = "Второй лейтенант"; break;
                case 41: R = "Первый лейтенант"; break;
                case 42: R = "Лейтенант"; break;
                case 43: R = "Старший лейтенант"; break;
                case 44: R = "Капитан-лейтенант"; break;
                case 45: R = "Капитан"; break;
                case 46: R = "Капитан разведки"; break;
                case 47: R = "Капитан спецназа"; break;
                case 48: R = "Майор"; break;
                case 49: R = "Подполковник"; break;
                case 50: R = "Полковник"; break;
                case 51: R = "Бригадный генерал"; break;
                case 52: R = "Генерал-майор"; break;
                case 53: R = "Генерал-лейтенант"; break;
                case 54: R = "Генерал-полковник"; break;
                case 55: R = "Генерал"; break;
                case 56: R = "Генерал армии"; break;
                case 57: R = "Главнокомандующий"; break;
                case 58: R = "Маршал"; break;
                case 59: R = "Верховный главнокомандующий"; break;
                case 60: R = "Warface"; break;
                case 61: R = "Лейтенант отряда «Бессмертные»"; break;
                case 62: R = "Старший лейтенант отряда «Бессмертные»"; break;
                case 63: R = "Капитан отряда «Бессмертные»"; break;
                case 64: R = "Майор отряда «Бессмертные»"; break;
                case 65: R = "Подполковник отряда «Бессмертные»"; break;
                case 66: R = "Полковник отряда «Бессмертные»"; break;
                case 67: R = "Генерал-майор отряда «Бессмертные»"; break;
                case 68: R = "Генерал-лейтенант отряда «Бессмертные»"; break;
                case 69: R = "Генерал-полковник отряда «Бессмертные»"; break;
                case 70: R = "Маршал отряда «Бессмертные»"; break;
                case 71: R = "Лейтенант отряда «Боги Войны»"; break;
                case 72: R = "Старший лейтенант отряда «Боги Войны»"; break;
                case 73: R = "Капитан отряда «Боги Войны»"; break;
                case 74: R = "Майор отряда «Боги Войны»"; break;
                case 75: R = "Подполковник отряда «Боги Войны»"; break;
                case 76: R = "Полковник отряда «Боги Войны»"; break;
                case 77: R = "Генерал-майор отряда «Боги Войны»"; break;
                case 78: R = "Генерал-лейтенант отряда «Боги Войны»"; break;
                case 79: R = "Генерал-полковник отряда «Боги Войны»"; break;
                case 80: R = "Маршал отряда «Боги Войны»"; break;
                case 81: R = "Лейтенант»"; break;
                case 82: R = "Старший лейтенант»"; break;
                case 83: R = "Капитан»"; break;
                case 84: R = "Майор»"; break;
                case 85: R = "Подполковник»"; break;
                case 86: R = "Полковник»"; break;
                case 87: R = "Генерал-майор»"; break;
                case 88: R = "Генерал-лейтенант»"; break;
                case 89: R = "Генерал-полковник»"; break;
                case 90: R = "Маршал»"; break;
            }
            return R;
        }

        int RankXP(int idRank)
        {
            int R = 0;
            switch (idRank)
            {
                case 1: R = 0; break;
                case 2: R = 700; break;
                case 3: R = 1400; break;
                case 4: R = 2400; break;
                case 5: R = 3900; break;
                case 6: R = 5800; break;
                case 7: R =8100; break;
                case 8: R = 11100; break;
                case 9: R = 14600; break;
                case 10: R = 18800; break;
                case 11: R = 23800; break;
                case 12: R = 29600; break;
                case 13: R = 36300; break;
                case 14: R = 44100; break;
                case 15: R = 53000; break;
                case 16: R = 63000; break;
                case 17: R = 74500; break;
                case 18: R = 87400; break;
                case 19: R = 102000; break;
                case 20: R = 118400; break;
                case 21: R = 136700; break;
                case 22: R = 157200; break;
                case 23: R = 180000; break;
                case 24: R = 205200; break;
                case 25: R = 233300; break;
                case 26: R = 264400; break;
                case 27: R = 298700; break;
                case 28: R = 336500; break;
                case 29: R = 378000; break;
                case 30: R = 423700 ; break;
                case 31: R = 473700 ; break;
                case 32: R = 528400; break;
                case 33: R = 588200; break;
                case 34: R = 653400; break;
                case 35: R = 724400; break;
                case 36: R = 801600; break;
                case 37: R = 885500; break;
                case 38: R = 976400; break;
                case 39: R = 1074800; break;
                case 40: R = 1181100; break;
                case 41: R = 1296000; break;
                case 42: R = 1419700; break;
                case 43: R = 1552900; break;
                case 44: R = 1692000 ; break;
                case 45: R = 1849900; break;
                case 46: R = 2014800; break;
                case 47: R = 2191200; break;
                case 48: R = 2380000 ; break;
                case 49: R = 2581500; break;
                case 50: R = 2796400; break;
                case 51: R = 3025300 ; break;
                case 52: R = 3268800; break;
                case 53: R = 3527500; break;
                case 54: R = 3801900; break;
                case 55: R = 4092800; break;
                case 56: R = 4400600; break;
                case 57: R = 4726000; break;
                case 58: R = 5069500; break;
                case 59: R = 5431800; break;
                case 60: R = 6000000; break;
                case 61: R = 6568200; break;
                case 62: R = 7136400; break;
                case 63: R = 7704600; break;
                case 64: R = 8272800; break;
                case 65: R = 8841000; break;
                case 66: R = 9409200; break;
                case 67: R = 9977400; break;
                case 68: R = 10545600; break;
                case 69: R = 11113800; break;
                case 70: R = 11682000; break;
                case 71: R = 12250200; break;
                case 72: R = 12818400; break;
                case 73: R = 13386600; break;
                case 74: R = 13954800; break;
                case 75: R = 14523000; break;
                case 76: R = 15091200; break;
                case 77: R = 15659400; break;
                case 78: R = 16227600; break;
                case 79: R = 16795800; break;
                case 80: R = 17364000; break;
                case 81: R = 17932200; break;
                case 82: R = 18500400; break;
                case 83: R = 19068600; break;
                case 84: R = 19636800; break;
                case 85: R = 20205000; break;
                case 86: R = 20773200; break;
                case 87: R = 21341400; break;
                case 88: R = 21909600; break;
                case 89: R = 22477800; break;
                case 90: R = 23046000; break;
            }
            return R;
        }
        /// <summary>
        /// Прогресс до следующего ранга
        /// </summary>
        /// <param name="userXP"></param>
        /// <returns></returns>
        decimal RankProgress()
        {
            if (JUser.rank_id == 80)
            {
                return 100;
            }
           
           float XP_Start = RankXP(JUser.rank_id);
           float XP_End = RankXP(JUser.rank_id + 1);
           float XP_Now = JUser.experience;
           float R = 100 * (XP_Now - XP_Start) / (XP_End - XP_Start);
           return (decimal)Math.Round(R);

        }

        /// <summary>
        /// Статистика УС
        /// </summary>
        /// <returns></returns>
        decimal UC()
        {
            float U1 = JUser.kills;
            float U2 = JUser.death;
            float U3 = U1 / U2;
            return (decimal)Math.Round(U3, 3);
        }

        /// <summary>
        /// Количество фрагов для убийств
        /// </summary>
        /// <returns></returns>
        int fragUC()
        {
            float U1 = 0.5f + (JUser.kills / (1000 * JUser.kills / JUser.death));
            return (int)Math.Round(U1);
        }

        int FragOST()
        {
            float U1 = JUser.kills;
            float U2 = JUser.death;
            float U3 = U1 / U2;
            float U4 = float.Parse(Math.Round(U3, 3).ToString()) + 0.00049999f;
            float F = JUser.kills / (1000 * JUser.kills / JUser.death);
            float delta = 0.5f + (F * (U4 - U3)*1000);
            return (int)Math.Round(delta);
        }

        public Info (UserInfo User)
        {
            JUser = User;
        }

        /// <summary>
        /// Загрузка ключей
        /// </summary>
        void LoadKey()
        {
            string S = JUser.full_response;
            S = S.Remove(0, 6);
            S = S.Remove(S.Length - 1);
            S = S.Replace("\n<Sum> ", "*");
            string[] strarray = S.Split('*');
            for (int k = 0; k < strarray.Count(); k++)//весь массив
            {
                string I = strarray[k];
                I = I.Replace(" ", "");
                string key = I.Substring(0, I.IndexOf('='));
                string sum = I.Substring(I.IndexOf('=') + 1, I.Length - I.IndexOf('=') - 1);

                if (!KeyUser.Contains(key)) { KeyUser.Add(key, Int32.Parse(sum)); }
                else
                {
                    throw new System.ArgumentException("Ошибка расшифровки ответа JSON от сервера: обнаружен повтор ключевого значения");
                }
            }
        }

        /// <summary>
        /// Время игры в ПВП
        /// </summary>
        /// <returns></returns>
        string PVP_time()
        {
            string R = "";

            int T_Recon = 0;
            if (KeyUser.ContainsKey("[class]Recon[mode]PVP[stat]player_playtime")) { T_Recon = (int)KeyUser["[class]Recon[mode]PVP[stat]player_playtime"]; }
            int T_Rifleman = 0;
            if (KeyUser.ContainsKey("[class]Rifleman[mode]PVP[stat]player_playtime")) { T_Rifleman = (int)KeyUser["[class]Rifleman[mode]PVP[stat]player_playtime"]; }
            int T_Engineer = 0;
            if (KeyUser.ContainsKey("[class]Engineer[mode]PVP[stat]player_playtime")) { T_Engineer = (int)KeyUser["[class]Engineer[mode]PVP[stat]player_playtime"]; }
            int T_Medic = 0;
            if (KeyUser.ContainsKey("[class]Medic[mode]PVP[stat]player_playtime")) {T_Medic = (int)KeyUser["[class]Medic[mode]PVP[stat]player_playtime"]; }
            int Sum = T_Recon + T_Rifleman + T_Engineer + T_Medic;
            int H = Sum / (600 * 60);
            int Mi = (Sum / 600) - H*60;
            R = ConvertINT(H) + " час " + Mi.ToString() + " мин";
            return R;

        }

        /// <summary>
        /// Время игры в ПВЕ
        /// </summary>
        /// <returns></returns>
        string PVE_time()
        {
            string R = "";
            int T_Recon = 0;
            if (KeyUser.ContainsKey("[class]Recon[mode]PVE[stat]player_playtime")) { T_Recon = (int)KeyUser["[class]Recon[mode]PVE[stat]player_playtime"]; }
            int T_Rifleman = 0;
            if (KeyUser.ContainsKey("[class]Rifleman[mode]PVE[stat]player_playtime")) { T_Rifleman = (int)KeyUser["[class]Rifleman[mode]PVE[stat]player_playtime"]; }
            int T_Engineer = 0;
            if (KeyUser.ContainsKey("[class]Engineer[mode]PVE[stat]player_playtime")) { T_Engineer = (int)KeyUser["[class]Engineer[mode]PVE[stat]player_playtime"]; }
            int T_Medic = 0;
            if (KeyUser.ContainsKey("[class]Medic[mode]PVE[stat]player_playtime")) { T_Medic = (int)KeyUser["[class]Medic[mode]PVE[stat]player_playtime"]; }
            int Sum = T_Recon + T_Rifleman + T_Engineer + T_Medic;
            int H = Sum / (600 * 60);
            int Mi = (Sum / 600) - H * 60;
            R = ConvertINT(H) + " час " + Mi.ToString() + " мин";
            return R;

        }
        /// <summary>
        /// Процент игры за пвп
        /// </summary>
        /// <returns></returns>
        decimal Proc_PVP()
        {
            float CountALL = JUser.playtime_h * 60 + JUser.playtime_m;
            int T_Recon = 0;
            if (KeyUser.ContainsKey("[class]Recon[mode]PVP[stat]player_playtime")) { T_Recon = (int)KeyUser["[class]Recon[mode]PVP[stat]player_playtime"]; }
            int T_Rifleman = 0;
            if (KeyUser.ContainsKey("[class]Rifleman[mode]PVP[stat]player_playtime")) { T_Rifleman = (int)KeyUser["[class]Rifleman[mode]PVP[stat]player_playtime"]; }
            int T_Engineer = 0;
            if (KeyUser.ContainsKey("[class]Engineer[mode]PVP[stat]player_playtime")) { T_Engineer = (int)KeyUser["[class]Engineer[mode]PVP[stat]player_playtime"]; }
            int T_Medic = 0;
            if (KeyUser.ContainsKey("[class]Medic[mode]PVP[stat]player_playtime")) { T_Medic = (int)KeyUser["[class]Medic[mode]PVP[stat]player_playtime"]; }
            int Sum = T_Recon + T_Rifleman + T_Engineer + T_Medic;
            int H = Sum / (600 * 60);
            int Mi = (Sum / 600) - H * 60;
            float CountPVP = H * 60 + Mi;
            float R = 100* CountPVP / CountALL;
            return (decimal)Math.Round(R);
        }

        /// <summary>
        /// Процент игры за пвe
        /// </summary>
        /// <returns></returns>
        string Proc_PVE()
        {
            float CountALL = JUser.playtime_h * 60 + JUser.playtime_m;
            int T_Recon = 0;
            if (KeyUser.ContainsKey("[class]Recon[mode]PVE[stat]player_playtime")) { T_Recon = (int)KeyUser["[class]Recon[mode]PVE[stat]player_playtime"]; }
            int T_Rifleman = 0;
            if (KeyUser.ContainsKey("[class]Rifleman[mode]PVE[stat]player_playtime")) { T_Rifleman = (int)KeyUser["[class]Rifleman[mode]PVE[stat]player_playtime"]; }
            int T_Engineer = 0;
            if (KeyUser.ContainsKey("[class]Engineer[mode]PVE[stat]player_playtime")) { T_Engineer = (int)KeyUser["[class]Engineer[mode]PVE[stat]player_playtime"]; }
            int T_Medic = 0;
            if (KeyUser.ContainsKey("[class]Medic[mode]PVE[stat]player_playtime")) { T_Medic = (int)KeyUser["[class]Medic[mode]PVE[stat]player_playtime"]; }
            int Sum = T_Recon + T_Rifleman + T_Engineer + T_Medic;
            int H = Sum / (600 * 60);
            int Mi = (Sum / 600) - H * 60;
            float CountPVP = H * 60 + Mi;
            float R = 100 * CountPVP / CountALL;
            if (Math.Round(R) > 20)
            {
                return "<span style='color: red'>" + Math.Round(R).ToString() + "%</span>";
            }
            else
            {
                return  Math.Round(R).ToString() + "%";
            }
        }
        /// <summary>
        /// Серия убийств
        /// </summary>
        /// <returns></returns>
        string SeriaUb()
        {
            int Kill = 0;
            if (KeyUser.ContainsKey("[mode]PVP[stat]player_kill_streak")) { Kill = (int)KeyUser["[mode]PVP[stat]player_kill_streak"]; }
            if (Kill > 50)
            {
                return "<span style='color: red'>"+Kill+"</span>";
            }
            else
            {
                return Kill.ToString();
            }
        }

        /// <summary>
        /// Кол-во покинутых матчей
        /// </summary>
        /// <returns></returns>
        int Col_ExitPVP()
        {
            if (KeyUser.ContainsKey("[mode]PVP[stat]player_sessions_left"))
            {
                return (int)KeyUser["[mode]PVP[stat]player_sessions_left"];
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// % покинутых матчей
        /// </summary>
        /// <returns></returns>
        string Proc_ExitPVP()
        {
            float ColExit = 0;
            if (KeyUser.ContainsKey("[mode]PVP[stat]player_sessions_left"))
            {
                ColExit = (int)KeyUser["[mode]PVP[stat]player_sessions_left"];
            }
            float Col1 = JUser.pvp_wins + JUser.pvp_lost;
            float R = 100 * (ColExit / Col1);
            if (Math.Round(R) >= 10)
            {
                return "<span style='color: red'>" + Math.Round(R).ToString() + "%</span>";
            }
            else
            {
                return  Math.Round(R).ToString()+"%";
            }
        }

        string ConvertINT(int I)
        {
            string R = I.ToString();
            string T = "";
            int b = 0;
            for (int k = R.Count()-1; k>=0; k--)//весь массив
            {
                if (b == 3) {b = 0;T = " " + T;}
                T = R[k] + T;
                b++;
            }
            return T;
        }

        /// <summary>
        /// Генерация отчета
        /// </summary>
        /// <returns></returns>
        public string HTML_Infо()
        {
            LoadKey();
            StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("<div class='StyleTable'>");
            sb.AppendLine("<table>");
            sb.AppendFormat("<thead><tr><td colspan='2'>{0}</td></tr></thead>", JUser.nickname);
            sb.AppendLine("<tbody>");
            sb.AppendFormat("<tr><td style='text-align: center'>{0}</td><td style='text-align: center'>{1}</td></tr>", RankName(JUser.rank_id), RankImage(JUser.rank_id));
            sb.AppendFormat("<tr><td>{0}</td><td>{1}</td></tr>", "Состоит в клане", JUser.clan_name);
            sb.AppendFormat("<tr><td>{0}</td><td>{1}</td></tr>", "Звание", JUser.rank_id);
            sb.AppendFormat("<tr><td>{0}</td><td>{1} / {2}%</td></tr>", "Опыт / пройдено до следующего звания",ConvertINT(JUser.experience), RankProgress());
            sb.AppendFormat("<tr><td>{0}</td><td>{1}</td></tr>", "Необходимо опыта до следующего звания",ConvertINT(RankXP(JUser.rank_id + 1) - JUser.experience));
            sb.AppendFormat("<tr><td>{0}</td><td>{1}</td></tr>", "Миссий PVE выполнено", ConvertINT(JUser.pve_wins));
            sb.AppendFormat("<tr><td>{0}</td><td>{1} / {2}</td></tr>", "Победы / поражения в PVP", ConvertINT(JUser.pvp_wins), ConvertINT(JUser.pvp_lost));
            sb.AppendFormat("<tr><td>{0}</td><td>{1}&nbsp;&nbsp;&nbsp;&nbsp;<span style='color: #006600'>&uarr;{2}</span>&nbsp;&nbsp;<span style='color: red'>&darr;{3}</span></td></tr>", "Соотношение убийств /смертей в PVP", UC(), FragOST(), fragUC() - FragOST());
            sb.AppendFormat("<tr><td>{0}</td><td>{1}</td></tr>", "Фрагов для изменения УС на 0.001", fragUC());
            sb.AppendFormat("<tr><td>{0}</td><td>{1} / {2}</td></tr>", "Лучшая серия убийств PVP / % ливов с PVP ", SeriaUb(), Proc_ExitPVP());
            sb.AppendFormat("<tr><td>{0}</td><td>{1} час {2} мин / {3}</td></tr>", "Общее время игры / % PVE игр ", ConvertINT(JUser.playtime_h), JUser.playtime_m, Proc_PVE());
            sb.AppendFormat("<tr><td>{0}</td><td>{1}</td></tr>", "Любимый класс (PVP)", ClassName(JUser.favoritPVP));
            sb.AppendFormat("<tr><td>{0}</td><td>{1}</td></tr>", "Время игры в PVP",PVP_time());
            sb.AppendFormat("<tr><td>{0}</td><td>{1}</td></tr>", "Любимый класс (PVE)", ClassName(JUser.favoritPVE));
            sb.AppendFormat("<tr><td>{0}</td><td>{1}</td></tr>", "Время игры в PVE", PVE_time());
            sb.AppendLine("</tbody>");
            sb.AppendLine("</table>");
            sb.AppendLine("</div>");
            return sb.ToString();
        }
    }
}