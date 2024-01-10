// See https://aka.ms/new-console-template for more information

using LinkedLists;
Console.WriteLine();
public static class Testing{
public static IEnumerable<string> Main(string[] lines)
{
    var graph = new Dictionary<string, Node>();

    foreach (var line in lines)
    {
        if (line.Contains(','))
        {
            string returnValue;

            try
            {
                returnValue = LinkedListIntersection(line.Split(',').Select(v => v.Trim()), graph).ToString();
            }
            catch (InvalidOperationException ex)
                when (ex.Message == "Cycle detected.")
            {
                returnValue = "Error Thrown!";
            }

            yield return returnValue;
        }
        else if (line.Contains("->"))
        {
            var splitStr = line.Split("->", StringSplitOptions.None);
            var current = splitStr[0];
            var next = splitStr[1];

            // Check to see if the parent node already exists
            if (!graph.TryGetValue(next, out var nextNode))
            {
                // If it doesn't, add it in so we can reference the object
                nextNode = new Node(next, null);
                graph.Add(next, nextNode);
            }

            // Check to see if the child node already exists
            if (graph.TryGetValue(current, out var currentNode))
            {
                // If it does, update the existing object
                currentNode.Next = nextNode;
            }
            else
            {
                graph.Add(current, new Node(current, nextNode));
            }
        }
    }
}

static bool LinkedListIntersection(IEnumerable<string> nodeGroup, IDictionary<string, Node> graph)
{
    var allTraversedNodes = new HashSet<string>();

    foreach (var value in nodeGroup)
    {
        var currentTraversedNodes = new HashSet<string>();

        if (!graph.TryGetValue(value, out var node))
        {
            continue;
        }

        do
        {
            if (allTraversedNodes.Contains(node.Value))
            {
                return true;
            }

            // Don't follow cycles
            if (currentTraversedNodes.Contains(node.Next?.Value))
            {
                throw new InvalidOperationException($"Cycle detected.");
            }

            allTraversedNodes.Add(node.Value);
            currentTraversedNodes.Add(node.Value);

            node = node.Next;
        } while (node != null);
    }

    return false;
}
}
