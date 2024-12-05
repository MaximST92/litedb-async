using Nuke.Common.CI.GitHubActions;

[GitHubActions(
	"pr",
	GitHubActionsImage.UbuntuLatest,
	On = [GitHubActionsTrigger.PullRequest],
	InvokedTargets = [nameof(Pack)],
	AutoGenerate = false,
	FetchDepth = 0,
	CacheKeyFiles = [])]
partial class Build;

