#pragma checksum "D:\SP stuff\Web Development\kachoweded - Copy\Learner\TMS\Views\AccountManager\UpdateUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0ec1df9073771f5f8e9b58bf14d71ab71ea7717"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AccountManager_UpdateUser), @"mvc.1.0.view", @"/Views/AccountManager/UpdateUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AccountManager/UpdateUser.cshtml", typeof(AspNetCore.Views_AccountManager_UpdateUser))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\SP stuff\Web Development\kachoweded - Copy\Learner\TMS\Views\_ViewImports.cshtml"
using TMS;

#line default
#line hidden
#line 2 "D:\SP stuff\Web Development\kachoweded - Copy\Learner\TMS\Views\_ViewImports.cshtml"
using TMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0ec1df9073771f5f8e9b58bf14d71ab71ea7717", @"/Views/AccountManager/UpdateUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b920ee378507dd0789e3303ed664c79361ef06d", @"/Views/_ViewImports.cshtml")]
    public class Views_AccountManager_UpdateUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("dataForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("\r\n<p class=\"h1\">Update User</p>\r\n\r\n");
            EndContext();
            BeginContext(35, 1397, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84cda369dc264dcc9d96c3de462bf0bd", async() => {
                BeginContext(55, 899, true);
                WriteLiteral(@"

    <div class=""form-group row"">
        <label class=""col-md-2 col-form-label"" for=""fullNameInput"">Full name</label>
        <div class=""col-md-6"">
            <input type=""text"" id=""fullNameInput"" name=""fullNameInput"" class=""form-control""
                   placeholder=""Full name"" value="""" />
        </div>
    </div>
    <div class=""form-group row"">
        <label class=""col-md-2 col-form-label"" for=""emailInput"">Email</label>
        <div class=""col-md-4"">
            <input type=""text"" id=""emailInput"" name=""emailInput"" class=""form-control ""
                   placeholder=""Email"" value="""" />
        </div>
    </div>
    <div class=""form-group row"">
        <label class=""col-md-2 col-form-label"" for=""roleIdInput"">Role</label>
        <div class=""col-md-4"">
            <select type=""text"" id=""roleIdInput"" name=""roleIdInput"" class=""form-control "">
                ");
                EndContext();
                BeginContext(954, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c4cdf688a684f04a6198feac9fbe1a1", async() => {
                    BeginContext(972, 17, true);
                    WriteLiteral("-- Select role --");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(998, 427, true);
                WriteLiteral(@"
            </select>
        </div>
    </div>

    <div class=""form-group row"">
        <div class=""col-10 offset-2"">
            <a class=""btn btn-secondary"" href=""/AccountManager/ManageUsers"">Cancel</a>
            <input type=""button"" class=""btn btn-danger"" value=""Delete"" id=""deleteButton"" />
            <input type=""button"" class=""btn btn-primary"" value=""Save"" id=""saveButton"" />
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1432, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1453, 4720, true);
                WriteLiteral(@"
    <script>
        (function () {
        const ID = getIdFromAddressBar();
        $.when(setupRoleListBox()).then(function (resp1) {
            //this callback will be fired once all ajax calls have finished.
            loadData();
        });

       
            jQuery('#saveButton').on('click', function () {

                let collectedFullName = jQuery('#fullNameInput').val();
                let collectedEmail = jQuery('#emailInput').val();
                let collectedRoleId = jQuery('#roleIdInput').val();


                /* Create a new JavaScript class */
                function WebFormData(inFullName, inEmail, inRoleId) {
                    this.fullName = inFullName;
                    this.email = inEmail;
                    this.roleId = inRoleId;
                }//End of WebFormData class definition

                //Create a object, webFormData by using WebFormData class
                let webFormData = new WebFormData(collectedFullName,
              ");
                WriteLiteral(@"      collectedEmail, collectedRoleId);


                $.ajax({
                    type: 'PUT',
                    url: '/API/AccountManager/UpdateUser/' + ID,
                    data: webFormData,
                    datatype: 'application/json',
                    contentType: 'application/x-www-form-urlencoded',
                }).done(function (data) {
                    console.dir(data);
                    new Noty({ text: data.message, type: 'success', layout: 'center' }).show();
                }).fail(function (data) {
                    if (data.responseJSON) {
                        new Noty({ text: data.responseJSON.message, type: 'error', layout: 'center' }).show();
                    } else {
                        new Noty({ text: 'Unable to create record.', type: 'error', layout: 'center' }).show();
                    }
                })
            }//end of anonymous function
            );//$.ajax().done().fail()

            function loadData() {
     ");
                WriteLiteral(@"           return $.ajax({
                    method: 'GET',
                    url: '/API/AccountManager/GetOneUser/' + ID,
                    dataType: 'json'
                }).done(function (data) {
                    jQuery('#fullNameInput').val(data.record.fullName);
                    jQuery('#emailInput').val(data.record.userName);
                    jQuery('#roleIdInput').val(data.record.roleId);
                });
            };//loadData
            function setupRoleListBox() {
                return $.ajax({
                    method: 'GET',
                    url: '/API/AccountManager/GetRolesForInputControls/',
                    dataType: 'json'
                }).done(function (data) {
                    let roleList = data.records;
                    for (let index = 0; index < roleList.length; index++) {
                        $('#roleIdInput').append($('<option value=""' + roleList[index].id + '"">' + roleList[index].roleName + '</option>'));
                 ");
                WriteLiteral(@"   }
                    });
            }//setupRoleListBox
            function getIdFromAddressBar() {
                //Get Id from the url string in the browser's address bar
                let urlArray = window.location.href.split('/');
                let id = urlArray[urlArray.length - 1];
                return id;
            };

            $('#deleteButton').on('click', function () {
                jQuery.ajax({
                    method: 'DELETE',
                    url: '/API/AccountManager/DeleteUser/' + ID
                }).done(function (data) {
                    //Referred to https://ned.im/noty/#/confirm to make a confirm dialog form
                    var noty = new Noty({
                        modal: true,
                        layout: 'center',
                        text: 'Deleted user record.',
                        buttons: [
                            Noty.button('BACK', 'btn btn-success', function () {
                                location.re");
                WriteLiteral(@"place('/AccountManager/ManageUsers');
                            }, { id: 'button1', 'data-status': 'ok' })
                        ]
                    });
                    noty.show();

                }).fail(function (data) {
                    console.log(data);
                    new Noty({
                        text: data.responseJSON.message, type: 'error',
                        layout: 'center',
                    }).show();//end of new Noty(..).show()
                });

            });////end of $('#deleteButton').on('click', anonymous function)


        })()
    </script>
");
                EndContext();
            }
            );
            BeginContext(6176, 2, true);
            WriteLiteral("\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
