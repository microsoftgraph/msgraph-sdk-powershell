### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Teams

$params = @{
	displayName = "thumbsup_custom"
	contentBytes = "iVBORw0KGgoAAAANSUhEUgAAADAAAAAwCAYAAABXAvmHAAAABHNCSVQICAgIfAhkiAAAAAlwSFlzAAAOxAAADsQBlSsOGwAABGhJREFU..."
}

New-MgBetaTeamworkMessagingCustomEmoji -BodyParameter $params

```
This example shows how to use the New-MgBetaTeamworkMessagingCustomEmoji Cmdlet.

