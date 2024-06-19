# dual-language-User-info-Form
Develop a web page that displays a form with two language tabs (English and Arabic). Each tab should have a repeatable input control block set containing fields for Name, Email, and Phone. The user should be able to add and remove these control block sets from the form. All fields will be mandatory.

**Settings** : The page should also have a radio button that allows the user to enable &quot;Add &amp; delete Control Block
Set&quot; between &quot;Only English&quot; and &quot;English &amp; Arabic&quot; options.

**Functionality Expected:**

**Case1**: If the &quot;Only English&quot; option is selected, the &quot;Add New&quot; &amp; &quot;Remove Block Set&quot; button should only appear
in the English tab. However, when a new control block set is added, it should automatically create a
corresponding block set in the Arabic tab as well. When an English block set is removed, the corresponding
Arabic block set should also be removed.

**Case2**: If &quot;English &amp; Arabic&quot; option is selected, the tabs should behave independently, allowing the user to add
and remove control block set for each language.
Upon form submission, all the values from both language tabs should be sent to the controller.

**Requirements:**
1. Implement the web page using .NET Core &amp; Razor Pages.
2. Use JavaScript/jQuery to handle the dynamic addition and removal of control sets.
3. Ensure that all the block set fields are mandatory.
