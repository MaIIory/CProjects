<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Virtual_fluid_bed_dryer.Main" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %> 
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    
    <style type="text/css">
        
        .auto-style2 {
            width: 100%;
        }

        .auto-style3 {
            width: 100%;
        }

        .auto-style4 {
            
        }
        .auto-style5 {
            color: #000000;
        }
        .auto-style8 {
            width: 250px;
        }

        
        .Tab .ajax__tab_header
{
    color: #4682b4;
    font-family:Calibri;
    font-size: 14px;
    font-weight: bold;
    background-color: #ffffff;
    margin-left: 0px;
}
/*Body*/
.Tab .ajax__tab_body
{
    border:1px solid #b4cbdf;
    padding-top:0px;
}
/*Tab Active*/
.Tab .ajax__tab_active .ajax__tab_tab
{
    color: #000000;
    background:url("../../tab_active.gif") repeat-x;
    height:20px;
}
.Tab .ajax__tab_active .ajax__tab_inner
{
    color: #ffffff;
    background:url("../../tab_left_active.gif") no-repeat left;
    padding-left:10px;
}
.Tab .ajax__tab_active .ajax__tab_outer
{
    color: #ffffff;
    background:url("../../tab_right_active.gif") no-repeat right;
    padding-right:6px;
}
/*Tab Hover*/
.Tab .ajax__tab_hover .ajax__tab_tab
{
    color: #000000;
    background:url("../../tab_hover.gif") repeat-x;
    height:20px;
}
.Tab .ajax__tab_hover .ajax__tab_inner
{
    color: #000000;
    background:url("../../tab_left_hover.gif") no-repeat left;
    padding-left:10px;
}
.Tab .ajax__tab_hover .ajax__tab_outer
{
    color: #000000;
    background:url("../../tab_right_hover.gif") no-repeat right;
    padding-right:6px;
}
/*Tab Inactive*/
.Tab .ajax__tab_tab
{
    color: #666666;
    background:url("../../tab_Inactive.gif") repeat-x;
    height:20px;
}
.Tab .ajax__tab_inner
{
    color: #666666;
    background:url("../../tab_left_inactive.gif") no-repeat left;
    padding-left:10px;
}
.Tab .ajax__tab_outer
{
    color: #666666;
    background:url("../../tab_right_inactive.gif") no-repeat right;
    padding-right:6px;
    margin-right: 2px;
}

.button4 {
font-family: Arial;
color: #000000;
font-size: 12px;
padding: 2.5px;
text-decoration: none;
margin-top: 2px;
background: -webkit-gradient(linear, 0 0, 0 100%, from(#cfcfcf), to(#ffffff));
background: -moz-linear-gradient(top, #cfcfcf, #ffffff);
}
.button4:hover {
background: #ffffff;
}

.button5 {
font-family: Arial;
color: #ffffff;
font-size: 12px;
padding: 3px;
text-decoration: none;
text-shadow: 1px 1px 3px #666666;
background: #cfa550;
}
.button5:hover {
background: #55a6cf;
}


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

        .auto-style9 {
            height: 28px;
        }

        .auto-style10 {
            width: 162px;
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
<script type="text/javascript" language="javascript">

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
            case "Start":
                return ("yes");
                break;
            case "Save and Close":
                return ("yes");
                break;
            default:
                return ("no");
                break;
        }
    }
    </script>
    

    


<asp:ScriptManager ID="ScriptManager1" runat="server"/>
    <asp:Label Id="l1" runat="server"></asp:Label>
        <asp:UpdatePanel ID="PleaseWaitPanel" runat="server" RenderMode="Inline">
                <ContentTemplate>

    <table class="auto-style2">
        <tr>
            <td class="tr_30">
                 <div class ="div_prop" style="height: auto">
            <div class="auto-style4">
                <span class="auto-style1">Product properties</span><br />
                <br />
            </div>
            <table class="auto-style2">
                <tr>
                    <td>Start Humidity:</td>
                     <td><asp:TextBox ID="txtProdHumidity" runat="server" Width="70px" Enabled="false" AutoPostBack="true"></asp:TextBox>
                         <span class="auto-style1">%</span></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:TextBox ID="txtTrackHumidity" runat="server" style="text-align: center" AutoPostBack="true" OnTextChanged="txtTrackHumidity_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">Mass:</td>
                    <td class="auto-style9">
                        <asp:TextBox ID="txtProdMass" runat="server" Width="70px" CausesValidation="True"></asp:TextBox>
                        <span class="auto-style1">kg</span>
                        <ajaxToolkit:MaskedEditExtender ID="meeProdMass" runat="server" TargetControlID="txtProdMass" Mask="99999"/>
                                                    <ajaxToolkit:MaskedEditValidator ID="mevProdMass" 
                                                         ControlExtender="meeProdMass"
                                                         runat="server"
                                                         ControlToValidate="txtProdMass"
                                                         InvalidValueMessage="Mass value is too less"
                                                         ValidationExpression="^[123456789]{1}.*$"
                                                         Display="Dynamic"
                                                         Text="*" 
                                                         InvalidValueBlurredMessage="*"
                                                         style="color: #CC0000">    
                                                    </ajaxToolkit:MaskedEditValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtProdMass" ErrorMessage="Product mass is mandatory" style="color: #CC0000">*</asp:RequiredFieldValidator>
                        
                    </td>
                </tr>
                <tr>
                    <td style="text-align: right">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnProdClear1" runat="server" CssClass="button4" Text="Clear" OnClick="btnProdClear1_Click" CausesValidation="False" />
                    </td>
                </tr>
                   



                </table>
                     
                     <br />
                     <asp:CheckBox ID="CheckBox2" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Change advenced product properties" ForeColor="White" />
                     
                     <br />
                     
                     
                     
                     <asp:PlaceHolder ID="plhProductAdvenced" runat="server" Visible="False"><br /><br /><table class="auto-style2">
                         <tr>
                             <td>Particle Diameter:</td>
                             <td>
                                 <asp:TextBox ID="txtProdParticle" runat="server" Width="70px" Text="200" AutoPostBack="False"></asp:TextBox>
                                 <span class="auto-style1">μm</span>
                                 <ajaxToolkit:MaskedEditExtender ID="meeProdParticle" runat="server" TargetControlID="txtProdParticle" Mask="999"/>
                                                    <ajaxToolkit:MaskedEditValidator ID="mevProdParticle" 
                                                         ControlExtender="meeProdParticle"
                                                         runat="server"
                                                         ControlToValidate="txtProdParticle"
                                                         InvalidValueMessage="Invalid particle diameter value"
                                                         ValidationExpression="^[123456789]{1}.*$"
                                                         Display="Dynamic"
                                                         Text="*" 
                                                         InvalidValueBlurredMessage="*"
                                                         style="color: #CC0000">    
                                                    </ajaxToolkit:MaskedEditValidator>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Particle diameter is mandatory" ControlToValidate="txtProdParticle" style="color: #CC0000" Text="*"></asp:RequiredFieldValidator>
                                 
                                 
                             </td>
                         </tr>
                         <tr>
                             <td style="text-align: right">
                                 <asp:Button ID="btnProdDef" runat="server" CssClass="button4" style="text-align: right" Text="Default" CausesValidation="False" OnClick="btnProdDef_Click" />
                             </td>
                             <td>
                                 <asp:Button ID="btnProdClear2" runat="server" CssClass="button4" Text="Clear" CausesValidation="False" OnClick="btnProdClear2_Click" />
                             </td>
                         </tr>
                     </table>
                         </asp:PlaceHolder>
                     &nbsp;
                      &nbsp;
                      &nbsp;
                 </div>

            </td>
            <td class="tr_30">
           <div class="div_prop" aria-orientation="horizontal" style="height: auto">
            <div class="auto-style4">
                <span class="auto-style1">Drying setting</span><br />
                                        <br />
                                        </div>
                                        <table class="auto-style3">
                                            <tr>
                                                <td class="auto-style10">Volume Flow Rate:</td>
                                                <td>
                                                    <asp:TextBox ID="txtVolFlowRate" runat="server"  Width="70px"></asp:TextBox>
                                                    <span class="auto-style1">m<span class="indeks_gorny">3</span>/h</span>
                                                    <ajaxToolkit:MaskedEditExtender ID="meeVolFlowRate" runat="server" TargetControlID="txtVolFlowRate" Mask="99999" AutoComplete="False" />
                                                    <asp:RegularExpressionValidator
                                                           Id="RegularExpressionValidator1"
                                                           runat="server"
                                                           ErrorMessage="Volume flow rate is too less (Minimum: 500)"
                                                           ControlToValidate="txtVolFlowRate"
                                                           ValidationExpression="([56789]{1}[0123456789]{2}.*)|([1234]{1}[0123456789]{3}.*)"
                                                           Text="*"
                                                           style="color: #CC0000"
                                                          >
                                                        </asp:RegularExpressionValidator>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtVolFlowRate" ErrorMessage="Volume flow rate is mandatory" style="color: #CC0000">*</asp:RequiredFieldValidator>
                                                    
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style10">Humidity Ratio:</td>
                                                <td>
                                                    <asp:TextBox ID="txtAirHumRatio" runat="server" Width="70px" ></asp:TextBox>
                                                    <span class="auto-style1">g/kg</span>
                                                    <ajaxToolkit:MaskedEditExtender ID="meeAirHumRatio" runat="server" TargetControlID="txtAirHumRatio"  Mask="999" AutoComplete="False"/>       
                                                    <ajaxToolkit:MaskedEditValidator ID="mevAirHumRatio" 
                                                         ControlExtender="meeAirHumRatio"
                                                         runat="server"
                                                         ControlToValidate="txtAirHumRatio"
                                                         InvalidValueMessage="Invalid value of humidity ratio"
                                                         ValidationExpression="^[123456789]+.*$"
                                                         Display="Dynamic"
                                                         Text="*"
                                                         InvalidValueBlurredMessage="*"
                                                        style="color: #CC0000"
                                                        >
                                                    </ajaxToolkit:MaskedEditValidator>   
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtAirHumRatio" ErrorMessage="Humidity ratio is mandatory" style="color: #CC0000" Display="Dynamic">*</asp:RequiredFieldValidator>
                                                    </td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style10">Temperature of Drying:</td>
                                                <td>
                                                <asp:TextBox ID="txtDryTemp" runat="server"  Width="70px" Text="60"></asp:TextBox>
                                                    <ajaxToolkit:MaskedEditExtender ID="meeDryTemp" runat="server" TargetControlID="txtDryTemp" Mask="999" AutoComplete="False" PromptCharacter=""/>
                                                    <asp:DropDownList ID="ddlTempOfDry" runat="server">
                                                        <asp:ListItem Value="0">°C </asp:ListItem>
                                                        <asp:ListItem Value="1">°F</asp:ListItem>
                                                        <asp:ListItem Value="2">°K</asp:ListItem>
                                                    </asp:DropDownList>
                                                    <ajaxToolkit:MaskedEditValidator ID="mevDryTemp" 
                                                         ControlExtender="meeDryTemp"
                                                         runat="server"
                                                         ControlToValidate="txtDryTemp"
                                                         InvalidValueMessage="Invalid dry temperature value"
                                                         ValidationExpression="^[123456789]{1}.*$"
                                                         Display="Dynamic"
                                                         Text="*"
                                                         InvalidValueBlurredMessage="*"
                                                        style="color: #CC0000"
                                                        ></ajaxToolkit:MaskedEditValidator>  
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Text="*" style="color: #CC0000" ErrorMessage="Temperature of drying is mandatory" ControlToValidate="txtDryTemp"></asp:RequiredFieldValidator>
                                                   
                                                   <%-- <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtTemperature" ControlToValidate="txtDryTemp" ErrorMessage="Drying temperature should be greater than start gas temperature" style="color: #CC0000" Operator="GreaterThan">*</asp:CompareValidator>--%>
                                                  </td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: right" class="auto-style10">&nbsp;</td>
                                                <td>
                                                    

                                                    <asp:Button ID="btnDryingClear" runat="server" CssClass="button4" Text="Clear" CausesValidation="False" OnClick="btnDryingClear_Click" />
                                                        
                                                </td>
                                            </tr>
                                            </table>
               <br />
               <asp:CheckBox ID="chbMachineAndGasProp" runat="server" AutoPostBack="True" ForeColor="White" OnCheckedChanged="chbMachineAndGasProp_CheckedChanged" Text="Change default machine settings and gas properties" />
               <br />
               <asp:PlaceHolder ID="plhMachineAndGasProp" runat="server" Visible="False">
                         
                   <table class="auto-style2">
                       <tr>
                           <td>Gas Type:</td>
                           <td>
                               <asp:DropDownList ID="ddlGasName" runat="server">
                                   <asp:ListItem>Air</asp:ListItem>
                               </asp:DropDownList>
                           </td>
                       </tr>
                       <tr>
                           <td>Start Gas Temperature:</td>
                           <td>
                               <asp:TextBox ID="txtTemperature" runat="server" Width="70px" Text="20"></asp:TextBox>
                               <ajaxToolkit:MaskedEditExtender ID="meeStartGasTemperature" runat="server" TargetControlID="txtTemperature" Mask="999" AutoComplete="False"/>
                                
                               <asp:DropDownList ID="ddlStartGasTemp" runat="server">
                                   <asp:ListItem Value="0">°C </asp:ListItem>
                                   <asp:ListItem Value="1">°F</asp:ListItem>
                                   <asp:ListItem Value="2">°K</asp:ListItem>
                               </asp:DropDownList>
                               <ajaxToolkit:MaskedEditValidator ID="mevStartGasTemperature"
                                                         ControlExtender="meeStartGasTemperature"
                                                         runat="server"
                                                         ControlToValidate="txtTemperature"
                                                         InvalidValueMessage="Invalid start gas temperature value"
                                                         ValidationExpression="^[123456789]{1}.*$"
                                                         Display="Dynamic"
                                                         Text="*"
                                                         InvalidValueBlurredMessage="*"
                                                        style="color: #CC0000"
                                                        >
                               </ajaxToolkit:MaskedEditValidator> 
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator6" Text="*"  runat="server" style="color: #CC0000" ErrorMessage="Start gas temperature is mandatory" ControlToValidate="txtTemperature"></asp:RequiredFieldValidator>
                           </td>
                       </tr>
                       <tr>
                           <td>Pressure<span class="auto-style5">:</span></td>
                           <td>
                               <asp:TextBox ID="txtPressure" runat="server" Width="70px" Text="1013,25"></asp:TextBox>
                               <span class="auto-style1">hPa</span>
                               <ajaxToolkit:MaskedEditExtender ID="meePressure" runat="server" TargetControlID="txtPressure" Mask="9999.99" MaskType="Number"/>
                               <asp:RegularExpressionValidator
                                   Id="regezp1"
                                   runat="server"
                                   ErrorMessage="Pressure range is between 900.00 and 1199.99 hPa"
                                   ControlToValidate="txtPressure"
                                   ValidationExpression="([^123456789]{1}[9]{1}.*[,]{1}.*)|([1]{1}[01]{1}.*[,]{1}.*)"
                                   Text="*"
                                   style="color: #CC0000"
                                  >
                               </asp:RegularExpressionValidator>
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" Text="*" style="color: #CC0000" ErrorMessage="Pressure is mandatory" ControlToValidate="txtPressure"></asp:RequiredFieldValidator>
                           </td>
                       </tr>
                       <tr>
                           <td>Machine Heating Rate:</td>
                           <td>
                               <asp:TextBox ID="txtHeatingSpeed" runat="server" Width="70px" Text="2,00"></asp:TextBox>
                               <ajaxToolkit:MaskedEditExtender ID="meeHeatingRate" runat="server" TargetControlID="txtHeatingSpeed" Mask="99.99" MaskType="Number" AutoComplete="True" />
                               <span class="auto-style1">%/min</span><asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" Text="*" style="color: #CC0000" ErrorMessage="Machine heating speed is mandatory" ControlToValidate="txtHeatingSpeed"></asp:RequiredFieldValidator>
                               <asp:RegularExpressionValidator
                                   Id="revHeatingRate"
                                   runat="server"
                                   ErrorMessage="Invalid heating rate value"
                                   ControlToValidate="txtHeatingSpeed"
                                   ValidationExpression="(.*[123456789]{1}.*)"
                                   Text="*"
                                   style="color: #CC0000"
                                  >
                                </asp:RegularExpressionValidator>
                           </td>
                       </tr>
                       <tr>
                           <td style="text-align: right">
                               <asp:Button ID="btnGasDef" runat="server" CssClass="button4" Text="Deafult" CausesValidation="False" OnClick="btnGasDef_Click" />
                           </td>
                           <td>
                               <asp:Button ID="btnGasClear" runat="server" CssClass="button4" Text="Clear" CausesValidation="False" OnClick="btnGasClear_Click" />
                           </td>
                       </tr>
                   </table>
         
                   </asp:PlaceHolder>

        <br />
    </div>
                &nbsp;</td>
            <td class="tr_30">


                                                    <div class="div_prop" style="height: auto">
                                                        <div class="auto-style4">
        <span class="auto-style1" >Choose your goal:<br />
                                                            </span><br />
                                                            <asp:CheckBox ID="chkGoal1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Estimate time to get desired level of humidity" AutoPostBack="True" />
                                                            <br />
                                                            <br />
                                                        </div>
                                                        
                                                        <asp:PlaceHolder ID="plhGoal1" runat="server" Visible="False">
                                                        <table class="auto-style2">
                                                            <tr>
                                                                <td class="auto-style8">
                                                                    <asp:Label ID="lblGoal1Text" runat="server" style="color: #FFFFFF" Text="Desired Humidity Value:" Enabled="False"></asp:Label>
                                                                </td>
                                                                <td>
                                                                    <asp:TextBox ID="txtHumidityLevel" runat="server" Enabled="false" Width="70px"></asp:TextBox>
                                                                    <span class="auto-style1">%</span></td>
                                                            </tr>
                                                            <tr>
                                                                <td class="auto-style8">&nbsp;</td>
                                                                <td>
                                                                    <asp:TextBox ID="txtHumLevel" runat="server" Width="70px"></asp:TextBox>
                                                                </td>
                                                            </tr>

                                                        </table>
                                                        </asp:PlaceHolder>

                                                        
                                                        
                                                        <br />
                                                        <asp:CheckBox ID="chkGoal2" runat="server" OnCheckedChanged="chkGoal2_CheckedChanged" Text="Estimate humidity for specified time of drying" AutoPostBack="True" Checked="True" />
                                                        <br />
                                                        <br />
                                                        <asp:PlaceHolder ID="plhGoal2" runat="server" Visible="True">
                                                        <table class="auto-style2">
                                                            <tr>
                                                                <td class="auto-style1">Time of Drying:</td>
                                                                <td>
                                                                    <asp:TextBox ID="txtDryTime" runat="server" Enabled="false" Width="70px"></asp:TextBox>
                                                                    <span class="auto-style1">min</span></td>
                                                            </tr>
                                                            <tr>
                                                                <td>&nbsp;</td>
                                                                <td>
                                                                    <asp:TextBox ID="txtTrackTime" runat="server" Width="70px"></asp:TextBox>
                                                                </td>
                                                            </tr>

                                                        </table>
                                                        
                                                        </asp:PlaceHolder>
                                                        <br />
              
        <br />
    </div>


                &nbsp;</td>
        </tr>


        <tr>

                    
            <td class="tr_30">
                 <asp:PlaceHolder ID="plhResult1" runat="server" Visible="False">
                     <div class="div_prop" style="background-color: #C9CDD4; height: 28em">
                       <span class="auto-style1" >Input gas properties</span>&nbsp;
                         <br />
                         <br />
                       <table class="auto-style2">
                <tr>
                    <td>Gas Type:</td>
                    <td><asp:Label ID="lblRsGasType" runat="server">Gas Type</asp:Label></td>
                </tr>
                <tr>
                    <td>Temperature:</td>
                    <td><asp:Label ID="lblRsInAirTemp" runat="server">Temperature</asp:Label></td>
                </tr>
                <tr>
                    <td>Volume Flow Rate: </td>
                    <td><asp:Label ID="lblRsVolFlowRate" runat="server">Volume Flow Rate</asp:Label></td>
                </tr>
                <tr>
                    <td>Humidity Ratio:</td>
                     <td><asp:Label ID="lblRsHumRatio" runat="server">Humidity Ratio</asp:Label></td>
                </tr>
                <tr>
                    <td>Pressure:</td>
                    <td><asp:Label ID="lblRsPressure" runat="server">Pressure</asp:Label></td>
                </tr>
                <tr>
                    <td>Specific Gas Const:</td>
                    <td><asp:Label ID="lblRsGasConst" runat="server">Specific Gas Const</asp:Label></td>
                </tr>
                <tr>
                    <td>Density:</td>
                    <td><asp:Label ID="lblRsDensity" runat="server">Density</asp:Label></td>
                </tr>
                <tr>
                    <td>Mass Flow Rate:</td>
                    <td><asp:Label ID="lblRsMassFlowRate" runat="server">Mass Flow Rate</asp:Label></td>
                </tr>
                <tr>
                    <td>Saturation Mixing Ratio:</td>
                    <td><asp:Label ID="lblRsSMR" runat="server">SMR</asp:Label></td>
                </tr>
                <tr>
                    <td>Relative Humidity:</td>
                    <td><asp:Label ID="lblRsRH" runat="server">RH</asp:Label></td>
                </tr>
                <tr>
                    <td>Wet Bulb Temperature:</td>
                    <td><asp:Label ID="lblRsWBT" runat="server">WBT</asp:Label></td>
                </tr>
            </table>
                     </div>

                 </asp:PlaceHolder>

            </td>
            <td class="tr_30" aria-orientation="horizontal">
                <asp:PlaceHolder ID="plhResult2" runat="server" Visible="False">
                <div class="div_prop" style="background-color: #C9CDD4; height: 28em">
                         <span class="auto-style1" >Product properties</span>&nbsp;
                         <br />
                         <br />
                <table class="auto-style2">
                <tr>
                    <td>Start Product Humidity:</td>
                    <td><asp:Label ID="lblRs2StartHumidity" runat="server">Start Prod Humidity</asp:Label></td>
                </tr>
                <tr>
                    <td>Start Product Mass:</td>
                    <td><asp:Label ID="lblRs2StartMass" runat="server">Start Prod msdd</asp:Label></td>
                </tr>
                <tr>
                    <td>Particle Diameter:</td>
                    <td><asp:Label ID="lblRs2ParticleDiameter" runat="server">Particle diameter</asp:Label></td>
                </tr>
                    <tr><td><br /></td></tr>
                <tr>
                <td><span class="auto-style1" >Drying settings</span>&nbsp;</td>
                </tr>
                   <tr><td><br /></td></tr>
                <tr>
                    <td>Heating Rate:</td>
                    <td><asp:Label ID="lblRs2HeatinRate" runat="server">Heating Rate</asp:Label></td>
                </tr>
                <tr>
                    <td>Temperature of Drying:</td>
                    <td><asp:Label ID="lblRs2DryingTemperature" runat="server">Temperature of Drying</asp:Label></td>
                </tr>
                <tr>
                    <td>Desired Humidity Level:</td>
                    <td><asp:Label ID="lblRs2DesHumLevel" runat="server">Desired hum level</asp:Label></td>
                </tr>
                <tr>
                    <td>Desired Time of Drying:</td>
                    <td><asp:Label ID="lblRs2DesTimeOfDry" runat="server">Desired time of dry</asp:Label></td>
                </tr>
                <tr>
                    <td colspan="2">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>

                     </div>

                 </asp:PlaceHolder>
                                    &nbsp;</td>
            <td class="tr_30">
                                 <asp:PlaceHolder ID="plhResult3" runat="server" Visible="False">
                     <div class="div_prop" style="background-color: #C9CDD4; height: 28em">
                           <span class="auto-style1" >Final Experiment Results</span>&nbsp;
                         <br />
                         <br />
                <table class="auto-style2">

                <tr>
                    <td>Total Time:</td>
                     <td><asp:Label ID="lblRs3TotalTime" runat="server">Total time</asp:Label></td>
                </tr>

                <tr>
                    <td>End Product Humidity:</td>
                    <td><asp:Label ID="lblRs3EndHumidity" runat="server">End humidity</asp:Label></td>
                </tr>
                <tr>
                    <td>End Product Mass:</td>
                    <td><asp:Label ID="lblRs3EndMass" runat="server">End mass</asp:Label></td>
                </tr>
                <tr>
                    <td>Desired humidity achieved:</td>
                    <td><asp:Label ID="lblRs3HumAchieved" runat="server">not set</asp:Label></td>
                </tr>
                <tr>
                    <td colspan="2">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>

                     </div>

                 </asp:PlaceHolder>
                                                    &nbsp;</td>
        </tr>
        </table>

     <asp:Panel ID="PleaseWaitMessagePanel" runat="server">
     <img src="Images/2854.gif" alt="Please wait"/>
     </asp:Panel>

<asp:Button ID="HiddenButton" runat="server" CssClass="hidden" Text="Hidden Button" ToolTip="Necessary for Modal Popup Extender" />
<ajaxToolkit:ModalPopupExtender ID="PleaseWaitPopup" BehaviorID="PleaseWaitPopup"
 runat="server" TargetControlID="HiddenButton" PopupControlID="PleaseWaitMessagePanel"
 BackgroundCssClass="modalBackground">
 </ajaxToolkit:ModalPopupExtender>


    <ajaxToolkit:SliderExtender ID="trackbar1" runat="server" TargetControlID="txtTrackHumidity" BoundControlID="txtProdHumidity" Minimum="5" Maximum="100"> </ajaxToolkit:SliderExtender>
    <ajaxToolkit:SliderExtender ID="trackbar2" runat="server" TargetControlID="txtTrackTime"  BoundControlID="txtDryTime" Minimum="1" Maximum="600"> </ajaxToolkit:SliderExtender>
    <ajaxToolkit:SliderExtender ID="trackbar4" runat="server" TargetControlID="txtHumLevel"  BoundControlID="txtHumidityLevel" Minimum="1" Maximum="100" Enabled="True"> </ajaxToolkit:SliderExtender>


         <asp:ValidationSummary ID="ValidationSummary1" runat="server" style="text-align: center; color: #CC0000" />  
                                                             
    <center>
        <div style="background-image: linear-gradient(to right, #FFFFFF 0%, #65a9d7 300%);">
            <%--<asp:Button ID="Savesdfdsf" runat="server" Text="Save" OnClick="Save_Click1" CausesValidation="False"/>--%>
            <asp:Button ID="btnStartCalc" runat="server"  CssClass="button99"  OnClick="btnStartCalc_Click" Text="Start" Width="150px"/>
        </div>
    </center>                
                    
</ContentTemplate>
<%--<Triggers>
       <asp:AsyncPostBackTrigger ControlID="btnStartCalc" EventName="Click" />
</Triggers>--%>
<%--<Triggers>
    <asp:PostBackTrigger ControlID="btnStartCalc" />
</Triggers>--%>
</asp:UpdatePanel>


<asp:Updatepanel ID="Update7" runat="server" UpdateMode="Conditional">
    <ContentTemplate>

        <table class="auto-style2"> 
        <tr>
            <td class="tr_30" colspan="3">
                
                <ajaxToolkit:TabContainer ID="plhResult4" runat="server" ActiveTabIndex="0" CssClass="Tab" Visible="false" >
                    <ajaxToolkit:TabPanel runat="server" HeaderText="TabPanel1" ID="TabPanel1">
                         <HeaderTemplate>
                        Product humidity
                        </HeaderTemplate>
                        <ContentTemplate>
                            <asp:Chart ID="chartResult1" runat="server">
                                <series>
                                    <asp:Series ChartType="Line" Name="Product Humidity"  YValuesPerPoint="2" ChartArea="ChartArea1" >
                                </asp:Series>
                                </series>
                                <chartareas>
                                    <asp:ChartArea Name="ChartArea1">
                                </asp:ChartArea>
                                </chartareas>
                            </asp:Chart>
                        </ContentTemplate>
                    </ajaxToolkit:TabPanel>
                    

                    <ajaxtoolkit:TabPanel ID="TabPanel2" runat="server" HeaderText="TabPanel2">
                        <HeaderTemplate>
                        Gas temperatures
                        </HeaderTemplate>
                        <ContentTemplate>
                            <asp:Chart ID="chartResult2" runat="server">

                                <chartareas>
                                    <asp:ChartArea Name="ChartArea2">
                                </asp:ChartArea>
                                </chartareas>
                            </asp:Chart>
                        </ContentTemplate>   
                    </ajaxtoolkit:TabPanel>


                    <ajaxtoolkit:TabPanel ID="TabPanel3" runat="server" HeaderText="TabPanel3">
                     <HeaderTemplate>
                        Product Mass
                        </HeaderTemplate>
                        <ContentTemplate>
                            <asp:Chart ID="chartResult3" runat="server">

                                <chartareas>
                                    <asp:ChartArea Name="ChartArea2">
                                </asp:ChartArea>
                                </chartareas>
                            </asp:Chart>
                        </ContentTemplate>   
                    </ajaxtoolkit:TabPanel>
                </ajaxToolkit:TabContainer>
            </td>
        </tr>
    
            <caption>
                <br />
                <br />
            </caption>

            </table>

         
         </ContentTemplate>
    </asp:Updatepanel>
    

                <asp:UpdatePanel ID="UpdatePanel1" runat="server" >
            <ContentTemplate>
                <center>
                <div style="background-image: linear-gradient(to left, #FFFFFF 0%, #65a9d7 300%);">
                    
                        <asp:Button ID="btnStoreResult" runat="server" CssClass="button99" OnClick="btnStoreResult_Click" Text="STORE RESULT" Width="150px" Visible="False" />
                    
                    </div>
                    </center>
                </ContentTemplate>
            </asp:UpdatePanel>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />

</asp:Content>




