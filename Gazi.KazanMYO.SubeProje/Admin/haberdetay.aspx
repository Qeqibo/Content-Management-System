<%@ Page Title="" Language="C#" MasterPageFile="~/AnaTema/master.Master"  AutoEventWireup="true" CodeBehind="haberdetay.aspx.cs" Inherits="Gazi.KazanMYO.SubeProje.AnaTema.haberdetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="wrap">  		 	       
         <div class="services_grid">
             <div class="content_bottom">
                 <asp:label  runat="server"  ID="lbl_HaberAd" text="lbl_HaberAd"></asp:label>
             </div>
		      <div class="content_bottom">
                  <asp:label runat="server" ID="lbl_HaberIcerık" text="lbl_Haberİcerik"></asp:label>
                  <%--<asp:Repeater ID="rp_haberler" runat="server">
                      <ItemTemplate>
		         			<div class="image group marketing">
									<div class="grid images_3_of_1">
										<a href="#"><img src="images/marketing_img1.jpg" alt=""></a>
                                        <asp:Image ID="Image1" ImageUrl='<%#Eval("Resim")%>' runat="server" />
									</div>
										<div class="grid blog-desc">
											<h4><a href="#"><%#Eval("HaberBaslik")%><%#Eval("Hab")%></a></h4>
											<p><%#Eval("Icerik")%></p>
											<div class="view-all"><a href="/haberdetay.aspx">Devamını Gör</a></div>
									 </div>
                                 
		  				      </div>
                          </ItemTemplate>
                      </asp:Repeater>--%>
		  				   <%--<div class="image group marketing">
									<div class="grid images_3_of_1">
										<a href="#"><img src="images/marketing_img2.jpg" alt=""></a>
									</div>
										<div class="grid blog-desc">
											<h4><a href="#">Duis aute irure dolor </a></h4>
											   <p>Lorem ipsum dolor sit amet Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
											<div class="view-all"><a href="events.html">More Info</a></div>
									 </div>
		  				      </div>
		  				   <div class="image group marketing">
									<div class="grid images_3_of_1">
										<a href="#"><img src="images/marketing_img3.jpg" alt=""></a>
									</div>
										<div class="grid blog-desc">
											<h4><a href="#">Deserunt mollit laborum</a></h4>
											   <p>Lorem ipsum dolor sit amet Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</p>
											<div class="view-all"><a href="events.html">More Info</a></div>
									 </div>
		  				      </div>--%>
		      			 </div>
    				</div>
    		<div class="sidebar">
	          
	    		 
	  		</div> 
    <div class="clear"></div>
 </div>
</asp:Content>
