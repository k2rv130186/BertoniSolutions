<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAlbum.aspx.cs" Inherits="WebAlbum.ViewAlbum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="Scripts/jquery-3.3.1.js"></script>
    <script src="Scripts/jcarousellite_1.0.1.js"></script>
    <script type="text/javascript">
        $(function() {
		    $(".carrusel").jCarouselLite({
			    btnNext: ".next",
			    btnPrev: ".prev"
		    });
	    });

    </script>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <br />
            <table class="auto-style1">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Lista de Album</td>
                    <td>
                        <asp:DropDownList ID="ddlstAlbun" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnVerAlbum" runat="server" OnClick="btnVerAlbum_Click" Text="Ver Album" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:GridView ID="gvFotos" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvFotos_SelectedIndexChanged" OnRowCommand="gvFotos_RowCommand">
                            <Columns>
                                <asp:BoundField DataField="Id" />
                                <asp:ImageField DataImageUrlField="ThumbnailUrl">
                                </asp:ImageField>
                                <asp:ButtonField Text="Ver Comentarios" ButtonType="Button"  CommandName="verComentario" />
                            </Columns>
                                
                        </asp:GridView>
                        <br />
                        <asp:GridView ID="gvComentarios" runat="server">
                        </asp:GridView>
                    </td>
                </tr>
            </table>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                 
                   <%-- <div class="carrusel">
                        <ul>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <table>
                                <tr>
                                    <td>
                                        <img src="Images/photo-album-icon.png" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <%# DataBinder.Eval(Container.DataItem, " Title")%>
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:Repeater>
                            </ul>
                    </div>
                    <button class="prev"><<</button>
                    <button class="next">>></button>--%>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
