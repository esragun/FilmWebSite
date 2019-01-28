<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Anasayfa.aspx.cs" Inherits="FilmSitesi.UI.Anasayfa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="w3_content_agilleinfo_inner">
        <div class="agile_featured_movies">
            <!--/agileinfo_tabs-->
            <div class="agileinfo_tabs">
                <!--/tab-section-->
                <div id="horizontalTab">
                    <div class="resp-tabs-container">
                        <div class="tab1">
                            <div class="tab_movies_agileinfo">
                                <div class="w3_agile_featured_movies">
                                    <div class="col-md-12 wthree_agile-movies_list">
                                        <asp:Repeater ID="rptFilmler" runat="server">
                                            <ItemTemplate>
                                                <div class="w3l-movie-gride-agile">
                                                    <div class="hvr-sweep-to-bottom">
                                                        <img src='<%#Eval("FilmPosterURL") %>' class="img-responsive" alt=" " style="height:300px;width:200px ">
                                                    </div>
                                                    <div class="mid-1 agileits_w3layouts_mid_1_home">
                                                        <div class="w3l-movie-text">
                                                            <h6><a href='FilmDetay.aspx?fid=<%#Eval("FilmID") %>'><%#Eval("FilmAdi") %></a></h6>
                                                        </div>
                                                    </div>
                                                </div>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </div>
                                    <div class="clearfix"></div>
                                </div>
                                <div class="cleafix"></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
