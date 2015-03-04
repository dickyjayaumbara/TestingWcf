<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="contactTitle" ContentPlaceHolderID="TitleContent" runat="server">
    Perhitungan - WCF
</asp:Content>

<asp:Content ID="contactContent" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <h1>Perhitungan Sederhana</h1>
    </hgroup>

    <form action="/ServiceWCF/Perhitungan" method="post">
        <input name="angkaPertamaStr" type="text" value="<%= ViewData["angkaPertama"] %>"/>
        <input name="angkaKeduaStr" type="text" value="<%= ViewData["angkaKedua"] %>"/>
        <span> = </span>
        <input name="hasil" type="text" value="<%= ViewData["hasil"] %>" readonly />
        <br />
        <button type="submit" name="tipePerhitungan" value="penjumlahan">Penjumlahan ( + ) </button>
        <button type="submit" name="tipePerhitungan" value="pengurangan">Pengurangan ( - ) </button>
        <button type="submit" name="tipePerhitungan" value="perkalian">Perkalian ( x ) </button>
        <button type="submit" name="tipePerhitungan" value="pembagian">Pembagian ( : ) </button>
    </form>
    
    <br />
    <hr size="1"/>
    <br />
    <table>
        <tr>
            <td colspan="3">Timeline</td>
        </tr>
        <tr>
            <td>Konten</td>
            <td>Waktu</td>
            <td>Detail</td>
        </tr>
        <tr>
            <td>Fokus Browsing WCF</td>
            <td>21:00</td>
            <td>browsing2, cari2 tutorial, tes tes kasar</td>
        </tr>
        <tr>
            <td>Bikin Aplikasi</td>
            <td>22:10</td>
            <td>mulai ngulik bikin wcf ama simple web nya</td>
        </tr>
        <tr>
            <td>Ngulik Github</td>
            <td>02:35</td>
            <td>ngulik github..., download instal dll..</td>
        </tr>
        <tr>
            <td colspan="3">Note : waktu nya di kira kira sih kurang lebih sekitaran jam sekian :)</td>
        </tr>
    </table>

    <br />
    <hr size="1"/>
    <br />
    <span>Hope : "besar harapan saya bisa bergabung bersama WGS..."</span>

</asp:Content>
