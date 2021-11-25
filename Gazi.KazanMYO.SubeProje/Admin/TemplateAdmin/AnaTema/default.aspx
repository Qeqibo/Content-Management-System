<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/TemplateAdmin/AnaTema/master.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Gazi.KazanMYO.SubeProje.AnaTema._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="wrap">  		 
	       <div class="sidebar">
	          <div class="sidebar_left_top">
	      	     <div class="services">
	      			<h3>Sayfalar</h3>
				      	<div class="services_list">

				      		<ul>
                                <asp:Repeater ID="rpt_sayfa" runat="server">
                                    <ItemTemplate>
						  		<li><a href="#">
                                <asp:Label ID="lbl_Sayfalar" runat="server" Text= '<%#Eval("PageName")%>'></asp:Label>
                                </a></li>
                                     </ItemTemplate>
						 
                                </asp:Repeater>
				    		</ul>
                              
				      </div>
	   			</div>
	 		</div>
	    		<%-- <div class="sidebar_left_bottom">
			    	<div class="projects">
			    		<h3>Projects</h3>
			    		<div class="project_img">
				    	   <img src="images/project1.jpg">
				    	   <img src="images/project2.jpg">
				    	    <div class="view-all"><a href="events.html">See All</a></div>
			    	   </div>
			    	</div>
	    		</div>--%>
	  		</div> 
       <div class="content">
		      <div class="content_bottom">
		      	<h2>Welcome to our company</h2>
		      	<h3>Lorem Ipsum is simply dummy text of the printing atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga.</h3>
		      	<p>At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident.At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga.</p>
		      	<p>Atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga.</p>
		      	     <div class="feature_list">
		      	     	<h2>Featured Services</h2>
		      		    <ul>
					  		<li>Duis aute irure dolor Sunt in culpa</li>
					  		<li>Sunt in culpa qui officia vel illum</li>
					  		<li>vel illum qui dolorem eum The wise</li>
					  		<li>The wise man therefore Lorem ipsum</li>
					  		<li>vel illum qui dolorem eum The wise</li>
		               </ul>
		      	   </div>
		      	   	  <p>At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident.At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia.</p>
		      </div>
    	</div>
    <div class="sidebar">
        <div class="sidebar_right_top">
     	  <h3>Haberler</h3>
     	   <div class="latestnews">
		     	 <div class="latestnews_desc">
		     		<h4>2017 Haziran</h4>
                      <ul>
                      <asp:Repeater ID="rpt_Haber" runat="server">
                                    <ItemTemplate>
						  		<li><a href="#">
                                <asp:Label ID="lbl_Haber" runat="server" Text= '<%#Eval("HaberBaslik")%>'></asp:Label>
                                </a></li>
                                     </ItemTemplate>
						 
                                </asp:Repeater>
		     		</ul>
		     	</div>
		     	
          </div>	
        </div>
        
       </div>
    <div class="clear"></div>
 </div>
</asp:Content>
