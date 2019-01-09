<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DataView.aspx.cs" Inherits="Virtual_fluid_bed_dryer.DataView" %>




<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
<style type="text/css"> 
.button99 {
   border-top: 1px solid #96d1f8;
   background: #74b2db;
   background: -webkit-gradient(linear, left top, left bottom, from(#3e779d), to(#74b2db));
   background: -webkit-linear-gradient(top, #3e779d, #74b2db);
   background: -moz-linear-gradient(top, #3e779d, #74b2db);
   background: -ms-linear-gradient(top, #3e779d, #74b2db);
   background: -o-linear-gradient(top, #3e779d, #74b2db);
   padding: 11px 22px;
   -webkit-border-radius: 14px;
   -moz-border-radius: 14px;
   border-radius: 14px;
   -webkit-box-shadow: rgba(0,0,0,1) 0 1px 0;
   -moz-box-shadow: rgba(0,0,0,1) 0 1px 0;
   box-shadow: rgba(0,0,0,1) 0 1px 0;
   text-shadow: rgba(0,0,0,.4) 0 1px 0;
   color: white;
   font-size: 14px;
   font-family: Georgia, serif;
   text-decoration: none;
   vertical-align: middle;
   margin-top: 25px;
   margin-bottom: 25px;
   }
.button99:hover {
   border-top-color: #28597a;
   background: #28597a;
   color: #ccc;
   }
.button99:active {
   border-top-color: #22242e;
   background: #22242e;
   }

.modalBackground {

    background-color:Gray;
    filter:alpha(opacity=70);
    opacity:0.7;
}

.modalPopup {
    background-color:#ffffdd;
    border-width:3px;
    border-style:solid;
    border-color:Gray;
    padding:3px;
    text-align:center;
}

.hidden {display:none}

</style>


         <script type="text/javascript">

             function pageLoad(sender, args) {
                 var sm = Sys.WebForms.PageRequestManager.getInstance();
                 if (!sm.get_isInAsyncPostBack()) {
                     sm.add_beginRequest(onBeginRequest);
                     sm.add_endRequest(onRequestDone);
                 }
             }

             function onBeginRequest(sender, args) {
                 var send = args.get_postBackElement().value;
                 if (displayWait(send) == "yes") {
                     $find('PleaseWaitPopup').show();
                 }
             }

             function onRequestDone() {
                 $find('PleaseWaitPopup').hide();
             }

             function displayWait(send) {
                 switch (send) {
                     case "RESTORE SELECTED":
                         return ("yes");
                         break;
                     case "Save and Close":
                         return ("yes");
                         break;
                     case "Start":
                         return ("yes");
                         break;
                     default:
                         return ("no");
                         break;
                 }
             }
    </script>

    <asp:ScriptManager ID="ScriptManager1" runat="server"/>
    <asp:UpdatePanel ID="PleaseWaitPanel" runat="server" RenderMode="Inline">
        <ContentTemplate>
    <asp:Label ID="lblUserId" runat="server" Text="1" Visible="False"></asp:Label>
    <asp:GridView ID="grvExperimentResult" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id" DataSourceID="SqlDataSource2" Font-Size="Smaller" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="grvExperimentResult_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowSelectButton="True" />
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="Start_humidity" HeaderText="Start humidity" SortExpression="Start_humidity" />
            <asp:BoundField DataField="Mass" HeaderText="Mass" SortExpression="Mass" />
            <asp:BoundField DataField="Volume_flow_rate" HeaderText="Volume flow rate" SortExpression="Volume_flow_rate" />
            <asp:BoundField DataField="Humidity_ratio" HeaderText="Humidity ratio" SortExpression="Humidity_ratio" />
            <asp:BoundField DataField="Drying_temperature" HeaderText="Drying temperature" SortExpression="Drying_temperature" />
            <asp:BoundField DataField="Desired_humidity_level" HeaderText="Desired humidity level" SortExpression="Desired_humidity_level" />
            <asp:BoundField DataField="Time_of_drying" HeaderText="Time of drying" SortExpression="Time_of_drying" />
            <asp:BoundField DataField="Particle_diameter" HeaderText="Particle diameter" SortExpression="Particle_diameter" />
            <asp:BoundField DataField="Gas_type" HeaderText="Gas type" SortExpression="Gas_type" />
            <asp:BoundField DataField="Start_gas_temperature" HeaderText="Start gas temperature" SortExpression="Start_gas_temperature" />
            <asp:BoundField DataField="Pressure" HeaderText="Pressure" SortExpression="Pressure" />
            <asp:BoundField DataField="Machine_heating_rate" HeaderText="Machine heating rate" SortExpression="Machine_heating_rate" />
            <asp:BoundField DataField="Product_final_hum" HeaderText="Product final hum" SortExpression="Product_final_hum" />
            <asp:BoundField DataField="Product_fianl_mass" HeaderText="Product final mass" SortExpression="Product_fianl_mass" />
            <asp:BoundField DataField="Total_time" HeaderText="Total time" SortExpression="Total_time" />
            <asp:BoundField DataField="Experiment_date" HeaderText="Experiment date" SortExpression="Experiment_date" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Database1ConnectionString %>" SelectCommand="SELECT [Id], [Start_humidity], [Volume_flow_rate], [Mass], [Humidity_ratio], [Drying_temperature], [Desired_humidity_level], [Product_fianl_mass], [Product_final_hum], [Machine_heating_rate], [Pressure], [Start_gas_temperature], [Gas_type], [Particle_diameter], [Time_of_drying], [Experiment_date], [Total_time] FROM [ExperimentResult] WHERE ([User_id] = @User_id)" DeleteCommand="DELETE FROM [ExperimentResult] WHERE [Id] = @Id" InsertCommand="INSERT INTO [ExperimentResult] ([Start_humidity], [Volume_flow_rate], [Mass], [Humidity_ratio], [Drying_temperature], [Desired_humidity_level], [Product_fianl_mass], [Product_final_hum], [Machine_heating_rate], [Pressure], [Start_gas_temperature], [Gas_type], [Particle_diameter], [Time_of_drying], [Experiment_date], [Total_time]) VALUES (@Start_humidity, @Volume_flow_rate, @Mass, @Humidity_ratio, @Drying_temperature, @Desired_humidity_level, @Product_fianl_mass, @Product_final_hum, @Machine_heating_rate, @Pressure, @Start_gas_temperature, @Gas_type, @Particle_diameter, @Time_of_drying, @Experiment_date, @Total_time)" UpdateCommand="UPDATE [ExperimentResult] SET [Start_humidity] = @Start_humidity, [Volume_flow_rate] = @Volume_flow_rate, [Mass] = @Mass, [Humidity_ratio] = @Humidity_ratio, [Drying_temperature] = @Drying_temperature, [Desired_humidity_level] = @Desired_humidity_level, [Product_fianl_mass] = @Product_fianl_mass, [Product_final_hum] = @Product_final_hum, [Machine_heating_rate] = @Machine_heating_rate, [Pressure] = @Pressure, [Start_gas_temperature] = @Start_gas_temperature, [Gas_type] = @Gas_type, [Particle_diameter] = @Particle_diameter, [Time_of_drying] = @Time_of_drying, [Experiment_date] = @Experiment_date, [Total_time] = @Total_time WHERE [Id] = @Id">
        <DeleteParameters>
            <asp:Parameter Name="Id" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="Start_humidity" Type="Int32" />
            <asp:Parameter Name="Volume_flow_rate" Type="Double" />
            <asp:Parameter Name="Mass" Type="Double" />
            <asp:Parameter Name="Humidity_ratio" Type="Double" />
            <asp:Parameter Name="Drying_temperature" Type="Double" />
            <asp:Parameter Name="Desired_humidity_level" Type="Double" />
            <asp:Parameter Name="Product_fianl_mass" Type="Double" />
            <asp:Parameter Name="Product_final_hum" Type="Double" />
            <asp:Parameter Name="Machine_heating_rate" Type="Double" />
            <asp:Parameter Name="Pressure" Type="Double" />
            <asp:Parameter Name="Start_gas_temperature" Type="Double" />
            <asp:Parameter Name="Gas_type" Type="String" />
            <asp:Parameter Name="Particle_diameter" Type="Double" />
            <asp:Parameter Name="Time_of_drying" Type="Int32" />
            <asp:Parameter DbType="Date" Name="Experiment_date" />
            <asp:Parameter Name="Total_time" Type="Int32" />
        </InsertParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="lblUserId" Name="User_id" PropertyName="Text" Type="Int32" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="Start_humidity" Type="Int32" />
            <asp:Parameter Name="Volume_flow_rate" Type="Double" />
            <asp:Parameter Name="Mass" Type="Double" />
            <asp:Parameter Name="Humidity_ratio" Type="Double" />
            <asp:Parameter Name="Drying_temperature" Type="Double" />
            <asp:Parameter Name="Desired_humidity_level" Type="Double" />
            <asp:Parameter Name="Product_fianl_mass" Type="Double" />
            <asp:Parameter Name="Product_final_hum" Type="Double" />
            <asp:Parameter Name="Machine_heating_rate" Type="Double" />
            <asp:Parameter Name="Pressure" Type="Double" />
            <asp:Parameter Name="Start_gas_temperature" Type="Double" />
            <asp:Parameter Name="Gas_type" Type="String" />
            <asp:Parameter Name="Particle_diameter" Type="Double" />
            <asp:Parameter Name="Time_of_drying" Type="Int32" />
            <asp:Parameter DbType="Date" Name="Experiment_date" />
            <asp:Parameter Name="Total_time" Type="Int32" />
            <asp:Parameter Name="Id" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>

        <asp:Label ID="lblResult" runat="server" Text="Label" Visible="False"></asp:Label>

    <br />


    <asp:Panel ID="PleaseWaitMessagePanel" runat="server" Height="50px" Width="125px">
     <img src="Images/Please_wait2.png" alt="Please wait"/>
     </asp:Panel>


<asp:Button ID="HiddenButton" runat="server" CssClass="hidden" Text="Hidden Button" ToolTip="Necessary for Modal Popup Extender" />
<ajaxToolkit:ModalPopupExtender ID="PleaseWaitPopup" BehaviorID="PleaseWaitPopup"
 runat="server" TargetControlID="HiddenButton" PopupControlID="PleaseWaitMessagePanel"
 BackgroundCssClass="modalBackground">
 </ajaxToolkit:ModalPopupExtender>

<center>
    <div style="background-image: linear-gradient(to right, #FFFFFF 0%, #65a9d7 300%);">
       <asp:Button ID="Save" runat="server" CssClass="button99" Text="RESTORE SELECTED" OnClick="Save_Click" />
    </div>
</center>
    </ContentTemplate>

<Triggers>
       <asp:AsyncPostBackTrigger ControlID="Save" EventName="Click" />
</Triggers>
</asp:UpdatePanel>
</asp:Content>
