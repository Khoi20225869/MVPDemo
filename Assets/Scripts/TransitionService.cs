using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UnityScreenNavigator.Runtime.Core.Page;

public static class TransitionService
{
        private static PageContainer pageContainer => PageContainer.Find("Container");

        public static void ApplicationStarted()
        {
                pageContainer.Push("MainPage", true, onLoad: x =>
                {
                        var page = x.page;
                        var presenter = new MainPresenter();
                        presenter.Init();

                        page.AddLifecycleEvent(onWillPushEnter: WillPushEnter, onWillPopExit: WillPopExit);
                        return;

                        async Task WillPushEnter()
                        {
                                await pageContainer.Preload("CustomizePage");
                        }

                        Task WillPopExit()
                        {
                                pageContainer.ReleasePreloaded("CustomizePage");
                                return Task.CompletedTask;
                        }
                });
        }

        public static void CustomizeClicked()
        {
                pageContainer.Push("CustomizePage", true, onLoad: x =>
                {
                        /*var page = x.page;
                        var presenter = new MainPresenter();
                        presenter.Init();

                        page.AddLifecycleEvent(onWillPushEnter: WillPushEnter, onWillPopExit: WillPopExit);
                        return;

                        async Task WillPushEnter()
                        {
                                await pageContainer.Preload("CustomizePage");
                        }

                        Task WillPopExit()
                        {
                                pageContainer.ReleasePreloaded("CustomizePage");
                                return Task.CompletedTask;
                        }*/
                });
        }
}