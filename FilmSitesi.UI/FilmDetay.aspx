<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FilmDetay.aspx.cs" Inherits="FilmSitesi.UI.FilmDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <script>(function (d, s, id) {
    var js, fjs = d.getElementsByTagName(s)[0];
    if (d.getElementById(id)) return;
    js = d.createElement(s); js.id = id;
    js.src = "//connect.facebook.net/en_GB/sdk.js#xfbml=1&version=v2.7";
    fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'facebook-jssdk'));</script>
    <style>
        .videoWrapper {
            position: relative;
            padding-bottom: 56.25%; /* 16:9 */
            padding-top: 25px;
            height: 0;
        }

            .videoWrapper iframe {
                position: absolute;
                top: 0;
                left: 0;
                width: 100%;
                height: 100%;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="w3_breadcrumb">
    </div>
    <div class="agile_featured_movies">
        <div class="inner-agile-w3l-part-head">
        </div>
        <div class="latest-news-agile-info">
            <div class="col-md-8 latest-news-agile-left-content">
                <%--<div class="single video_agile_player">
                    <div class="video-grid-single-page-agileits">--%>
                <div class="videoWrapper">
                    <iframe width="560" height="315" src="#" runat="server" id="ifVideo"></iframe>
                </div>
                <%-- </div>
                </div>--%>
                <div class="single-agile-shar-buttons">
                    <h5>Share This :</h5>
                    <ul>
                        <li>
                            <div class="fb-like" data-href="https://www.facebook.com/w3layouts" data-layout="button_count" data-action="like" data-size="small" data-show-faces="false" data-share="false"></div>
                        </li>
                        <li>
                            <div class="fb-share-button" data-href="https://www.facebook.com/w3layouts" data-layout="button_count" data-size="small" data-mobile-iframe="true"><a class="fb-xfbml-parse-ignore" target="_blank" href="https://www.facebook.com/sharer/sharer.php?u=https%3A%2F%2Fwww.facebook.com%2Fw3layouts&amp;src=sdkpreparse">Share</a></div>
                        </li>
                        <li class="news-twitter">
                            <a href="https://twitter.com/w3layouts" class="twitter-follow-button" data-show-count="false">Follow @w3layouts</a><script async src="//platform.twitter.com/widgets.js" charset="utf-8"></script>
                        </li>
                        <li>
                            <a href="https://twitter.com/intent/tweet?screen_name=w3layouts" class="twitter-mention-button" data-show-count="false">Tweet to @w3layouts</a><script async src="//platform.twitter.com/widgets.js" charset="utf-8"></script>
                        </li>
                        <li>
                            <!-- Place this tag where you want the +1 button to render. -->
                            <div class="g-plusone" data-size="medium"></div>

                            <!-- Place this tag after the last +1 button tag. -->
                            <script type="text/javascript">
                                (function () {
                                    var po = document.createElement('script'); po.type = 'text/javascript'; po.async = true;
                                    po.src = 'https://apis.google.com/js/platform.js';
                                    var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(po, s);
                                })();
                            </script>
                        </li>
                    </ul>
                </div>
                <div class="admin-text" style="background-color: white"">
                    url
                </div>
            </div>
            <div class="col-md-4 latest-news-agile-right-content">
                <h1>Film Bilgileri</h1><br /><br />
                <div class="side-bar-form">
                    <asp:Repeater ID="rptFilmBilgi" runat="server">
                        <ItemTemplate>
                                <img src='<%#Eval("PosterURL") %>' alt='<%#Eval("FilmAdi") %>' style="width: 200px; height: 300px" />
                                <br /><br />
                                <p style="color: black">Film Adı: <%#Eval("FilmAdi") %></p>
                                <p style="color: black">Yapım Yılı: <%#Eval("Yil") %></p>
                                <p style="color: black">Süre: <%#Eval("Sure") %> Saat</p>
                                <p style="color: black">Dil: <%#Eval("Dil") %></p>
                                <p style="color: black">Konu: <%#Eval("Aciklama") %></p>
                        </ItemTemplate>
                    </asp:Repeater>

                        Oyuncular:
                        <asp:Repeater ID="rptOyuncular" runat="server">
                            <ItemTemplate>
                                <a href="#"><%#Eval("OyuncuAdSoyad")%></a>
                            </ItemTemplate>
                        </asp:Repeater>
                    <br />
                        Yönetmenler:
                        <asp:Repeater ID="rptYonetmen" runat="server">
                            <ItemTemplate>
                                <a href="#"><%#Eval("YonetmenAdSoyad")%></a>
                            </ItemTemplate>
                        </asp:Repeater>
                    <br />
                        Tür:
                        <asp:Repeater ID="rptTur" runat="server">
                            <ItemTemplate>
                                <a href="#"><%#Eval("FilmTurAdi")%></a>
                            </ItemTemplate>
                        </asp:Repeater>
                    <br />
                        Ülke:
                        <asp:Repeater ID="rptUlke" runat="server">
                            <ItemTemplate>
                                <a href="#"><%#Eval("UlkeAdi")%></a>
                            </ItemTemplate>
                        </asp:Repeater>
                </div>
            </div>
            <div class="clearfix"></div>
        </div>
        <div class="clearfix"></div>
        <div class="clearfix"></div>
    </div>

</asp:Content>
