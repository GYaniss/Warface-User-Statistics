using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using Warface;

public partial class _Default : System.Web.UI.Page
{
    /// <summary>
    /// Никнейм игрока
    /// </summary>
    string UserName
    {
        get
        {
            return TB1.Text.Trim();
        }
    }
    /// <summary>
    /// Сервер игрока
    /// </summary>
    Warface.Server UserServer
    {
        get
        {
            Warface.Server S = Warface.Server.Альфа;
            if (D1.SelectedValue == "1")
            {
                S = Warface.Server.Браво;
            }
            if (D1.SelectedValue == "2")
            {
                S = Warface.Server.Чарли;
            }
            return S;
        }
    }
    /// <summary>
    /// Строка ошибки
    /// </summary>
    string ErrorString
    {
        set
        {
            ErrTxt.Text = value;
            if (value.Length == 0)
            {
                ErrTxt.Visible = false;
            }
            else
            {
                ErrTxt.Visible = true;
            }
           
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        ErrorString = "";
        if (IsPostBack) 
        {
            if (UserName.Length == 0) { ErrorString = "Имя игрока не задано."; return; }
            object UserData = null;
            try
            {
                UserData = Warface.HTTPGET.GetUserInfo(UserName, UserServer);
            }
            catch (Exception Err)
            {
                ErrorString = Err.Message;
                return;
            }

            if (UserData is ErrorInfo)
            {
                ErrorString = "Сервер " + D1.SelectedItem.Text + " " + UserName + " " + ((ErrorInfo)UserData).Message;
                return;
            }
            Info I = new Info((UserInfo)UserData);
            Gen.Text = I.HTML_Infо();
        }
    }
}