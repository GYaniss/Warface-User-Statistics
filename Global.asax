<%@ Application Language="C#" %>

<script runat="server">
    protected void Application_PreSendRequestHeaders()
    {
        this.Response.Headers.Remove("Server");
    }
</script>
