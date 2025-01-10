namespace OnlineB2BStoreBackend.Domain.Utility.MenuGroup
{
    public static class MenuGroupUtility
    {
        public static int GetMenuGroupLevel(this int id, IEnumerable<Models.MenuGroup> menuGroupList)
        {
            var menuGroup = menuGroupList.FirstOrDefault(m => m.MenuGroupId == id);
            if (menuGroup?.MenuGroupParentId == null || menuGroup?.MenuGroupParentId == 0)
                return 1;
            else
            {
                var menuGropParent = menuGroupList.FirstOrDefault(mp => mp.MenuGroupId == menuGroup?.MenuGroupParentId);

                if (menuGropParent?.MenuGroupParentId == null || menuGropParent?.MenuGroupParentId == 0)
                    return 2;
                else
                    return 3;
            }
        }
    }
}
