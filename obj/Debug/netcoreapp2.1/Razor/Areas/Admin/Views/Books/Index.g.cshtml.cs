#pragma checksum "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30d60390cef4b2621521bed9718b345737aab9ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Books_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Books/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Books/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Books_Index))]
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
#line 3 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Index.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30d60390cef4b2621521bed9718b345737aab9ac", @"/Areas/Admin/Views/Books/Index.cshtml")]
    public class Areas_Admin_Views_Books_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.PagingList<BookShop.Models.ViewModels.BooksIndexViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("select2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "row", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("px-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 6 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Admin.cshtml";

#line default
#line hidden
            BeginContext(354, 847, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-header bg-light"">
                لیست کتاب ها
            </div>
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-md-4 mb-3"">
                        <div class=""input-group"">
                            <span class=""input-group-btn"">
                                <button type=""button"" class=""btn btn-primary""><i class=""fa fa-search""></i> جستجو</button>
                            </span>
                            <input id=""input-group-1"" name=""input1-group2"" class=""form-control"" placeholder=""عنوان کتاب را واردکنید ..."" type=""text"">
                        </div>
                    </div>
                    <div class=""col-md-4"">
                        ");
            EndContext();
            BeginContext(1201, 668, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ebfbe3aee1c48dea50b13b9d4c87fc4", async() => {
                BeginContext(1220, 247, true);
                WriteLiteral("\r\n                            <div class=\"row form-group\">\r\n                                <label class=\"ml-2\">تعداد ردیف</label>\r\n                                <div class=\"col-md-4 form-group padding-0px\">\r\n                                    ");
                EndContext();
                BeginContext(1467, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f645c6c160da4c86aa360fd7b60f4940", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 32 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.RowID;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1538, 324, true);
                WriteLiteral(@"
                                </div>
                                <div class=""col-md-3 padding-0px"">
                                    <input type=""submit"" value=""نمایش بده"" class=""btn btn-primary float-left"" />
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1869, 479, true);
            WriteLiteral(@"
                    </div>
                </div>

                <p>
                    <a class=""btn btn-primary btn-block"" data-toggle=""collapse"" href=""#collapseExample"" role=""button"" aria-expanded=""false"" aria-controls=""collapseExample"">
                        جستجوی پیشرفته کتاب
                    </a>
                </p>
                <div class=""collapse"" id=""collapseExample"">
                    <div class=""card card-body"">
                        ");
            EndContext();
            BeginContext(2348, 3964, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "684fe76df8884c408174ad097eeead36", async() => {
                BeginContext(2354, 1148, true);
                WriteLiteral(@"
                            <div class=""row"">
                                <div class=""col-md-3"">
                                    <div class=""form-group"">
                                        <label class=""form-control-label"">عنوان</label>
                                        <input class=""form-control"" placeholder=""عنوان"">
                                    </div>
                                </div>
                                <div class=""col-md-3"">
                                    <div class=""form-group"">
                                        <label class=""form-control-label"">شابک</label>
                                        <input class=""form-control"" placeholder=""شابک"">
                                    </div>
                                </div>
                                <div class=""col-md-3"">
                                    <div class=""form-group"">
                                        <label class=""form-control-label"">زبان</label>
         ");
                WriteLiteral("                               <select class=\"select2 js-states form-control\">\r\n                                            ");
                EndContext();
                BeginContext(3502, 22, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baacc8c910f34b948b92febb15dc7d38", async() => {
                    BeginContext(3510, 5, true);
                    WriteLiteral("فارسی");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3524, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(3570, 21, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "769bead983404b11bee29b937b73ad89", async() => {
                    BeginContext(3578, 4, true);
                    WriteLiteral("عربی");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3591, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(3637, 23, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d973a9986fa4b81ba3bac42372b9a8d", async() => {
                    BeginContext(3645, 6, true);
                    WriteLiteral("purple");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3660, 481, true);
                WriteLiteral(@"
                                        </select>
                                    </div>
                                </div>
                                <div class=""col-md-3"">
                                    <div class=""form-group"">
                                        <label class=""form-control-label"">دسته بندی</label>
                                        <select class=""select2 js-states form-control"">
                                            ");
                EndContext();
                BeginContext(4141, 22, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5127f02051824434851976b046fd1ce0", async() => {
                    BeginContext(4149, 5, true);
                    WriteLiteral("فارسی");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4163, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(4209, 21, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a19877d49f67442ea4e8c0f1100679a3", async() => {
                    BeginContext(4217, 4, true);
                    WriteLiteral("عربی");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4230, 479, true);
                WriteLiteral(@"
                                        </select>
                                    </div>
                                </div>
                                <div class=""col-md-3"">
                                    <div class=""form-group"">
                                        <label class=""form-control-label"">نویسنده</label>
                                        <select class=""select2 js-states form-control"">
                                            ");
                EndContext();
                BeginContext(4709, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31b61cfefe5a48c4860f07147c460c07", async() => {
                    BeginContext(4717, 13, true);
                    WriteLiteral("آرزو ابراهیمی");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4739, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(4785, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe9f4a5556044f4c84ecbac981ac1a4c", async() => {
                    BeginContext(4793, 11, true);
                    WriteLiteral("زهرا رحمانی");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4813, 477, true);
                WriteLiteral(@"
                                        </select>
                                    </div>
                                </div>
                                <div class=""col-md-3"">
                                    <div class=""form-group"">
                                        <label class=""form-control-label"">مترجم</label>
                                        <select class=""select2 js-states form-control"">
                                            ");
                EndContext();
                BeginContext(5290, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8846afe92774aeab982e606dbe40d44", async() => {
                    BeginContext(5298, 13, true);
                    WriteLiteral("آرزو ابراهیمی");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5320, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(5366, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb075d6c3d3741068dfcf8e1f631a4b1", async() => {
                    BeginContext(5374, 11, true);
                    WriteLiteral("زهرا رحمانی");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5394, 476, true);
                WriteLiteral(@"
                                        </select>
                                    </div>
                                </div>
                                <div class=""col-md-3"">
                                    <div class=""form-group"">
                                        <label class=""form-control-label"">ناشر</label>
                                        <select class=""select2 js-states form-control"">
                                            ");
                EndContext();
                BeginContext(5870, 29, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a54a524ce864338af7aa862151bbe48", async() => {
                    BeginContext(5878, 12, true);
                    WriteLiteral("انتشارات رسا");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5899, 406, true);
                WriteLiteral(@"

                                        </select>
                                    </div>
                                </div>
                                <div class=""col-md-12"">
                                    <input type=""submit"" value=""جستجو"" class=""btn btn-success float-left"" />
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6312, 893, true);
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""table-responsive"">
                    <table class=""table table-bordered"">
                        <thead>
                            <tr>
                                <th>ردیف</th>
                                <th>عنوان</th>
                                <th>نویسندگان</th>
                                <th>شابک</th>
                                <th>موجودی</th>
                                <th>ناشر</th>
                                <th class=""text-center"">قیمت (ریال)</th>
                                <th class=""text-center"">تاریخ انتشار در سایت</th>
                                <th style=""width:25px;"">وضعیت</th>
                                <th>عملیات</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 133 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Index.cshtml"
                              int i = ViewBag.NumOfPage;

#line default
#line hidden
            BeginContext(7264, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 134 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(7353, 98, true);
            WriteLiteral("                                <tr>\r\n                                    <td class=\"text-center\">");
            EndContext();
            BeginContext(7452, 1, false);
#line 137 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Index.cshtml"
                                                       Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(7453, 67, true);
            WriteLiteral("</td>\r\n                                    <td class=\"text-nowrap\">");
            EndContext();
            BeginContext(7521, 10, false);
#line 138 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Index.cshtml"
                                                       Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(7531, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(7579, 11, false);
#line 139 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Index.cshtml"
                                   Write(item.Author);

#line default
#line hidden
            EndContext();
            BeginContext(7590, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(7638, 9, false);
#line 140 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Index.cshtml"
                                   Write(item.ISBN);

#line default
#line hidden
            EndContext();
            BeginContext(7647, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(7695, 10, false);
#line 141 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Index.cshtml"
                                   Write(item.Stock);

#line default
#line hidden
            EndContext();
            BeginContext(7705, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(7753, 18, false);
#line 142 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Index.cshtml"
                                   Write(item.PublisherName);

#line default
#line hidden
            EndContext();
            BeginContext(7771, 67, true);
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\">");
            EndContext();
            BeginContext(7839, 10, false);
#line 143 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Index.cshtml"
                                                       Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(7849, 69, true);
            WriteLiteral("</td>\r\n                                    <td class=\"text-center\">\r\n");
            EndContext();
#line 145 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Index.cshtml"
                                         if (item.PublishDate != null)
                                        {
                                            

#line default
#line hidden
            BeginContext(8078, 75, false);
#line 147 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Index.cshtml"
                                       Write(convertDate.ConvertMiladiToShamsi((DateTime)item.PublishDate, "yyyy/MM/dd"));

#line default
#line hidden
            EndContext();
#line 147 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Index.cshtml"
                                                                                                                        
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(8287, 60, true);
            WriteLiteral("                                            <span>-</span>\r\n");
            EndContext();
#line 152 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(8390, 105, true);
            WriteLiteral("                                    </td>\r\n                                    <td class=\"text-center\">\r\n");
            EndContext();
#line 155 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Index.cshtml"
                                         if (item.IsPublish == true)
                                        {

#line default
#line hidden
            BeginContext(8608, 108, true);
            WriteLiteral("                                            <label class=\"badge badge-success btn-block\">منتشر شده</label>\r\n");
            EndContext();
#line 158 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Index.cshtml"
                                        }

                                        else
                                        {

#line default
#line hidden
            BeginContext(8850, 104, true);
            WriteLiteral("                                            <label class=\"badge badge-info btn-block\">پیش نویس</label>\r\n");
            EndContext();
#line 163 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(8997, 542, true);
            WriteLiteral(@"
                                    </td>
                                    <td class=""text-center"">
                                        <a class=""btn btn-info btn-icon""><i class=""fa fa-eye text-white""></i></a>
                                        <a class=""btn btn-success btn-icon""><i class=""fa fa-edit text-white""></i></a>
                                        <a class=""btn btn-danger btn-icon""><i class=""fa fa-trash text-white""></i></a>
                                    </td>
                                </tr>
");
            EndContext();
#line 172 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Index.cshtml"
                                i++;
                            }

#line default
#line hidden
            BeginContext(9608, 119, true);
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n\r\n                    <nav>\r\n                        ");
            EndContext();
            BeginContext(9728, 74, false);
#line 179 "C:\Users\kakero\Desktop\BookShop\Library-site\Areas\Admin\Views\Books\Index.cshtml"
                   Write(await this.Component.InvokeAsync("Pager", new { PagingList = this.Model }));

#line default
#line hidden
            EndContext();
            BeginContext(9802, 32, true);
            WriteLiteral("\r\n                    </nav>\r\n\r\n");
            EndContext();
            BeginContext(9969, 106, true);
            WriteLiteral("\r\n                    \r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public BookShop.Classes.ConvertDate convertDate { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.PagingList<BookShop.Models.ViewModels.BooksIndexViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
