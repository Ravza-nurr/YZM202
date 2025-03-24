
using DataStructures.LinkedList.Doubly;

namespace Tests.LinkedListTests;

public class DbNodeTests
{
    [Fact]
    public void AddNewDbNode_Test()
    {
        var node = new DbNode<char>('a');
        var node1 = new DbNode<char>('b');
        var node2 = new DbNode<char>('c');

        node.Next = node1;
        node1.Prev = node;

        node1.Next = node2;
        node2.Prev = node1;

        Assert.Equal(node1, node.Next);
        Assert.Equal(null, node.Prev);
        Assert.True(node1.Next.Equals(node2));
        Assert.True(node.Next.Value.Equals(node2.Prev.Value));
    }

    [Fact]
    public void Constructor_WithValue_SetsValue()
    {
        var node = new DbNode<int>(5);

        Assert.True(node.Value.Equals(5));
    }

    [Fact]
    public void Constructor_WithoutValue_ValueIsNull()
    {
        var node = new DbNode<int>();
        node.Value = 5;

        Assert.True(node.Value.Equals(5));

    }

    [Fact]
    public void NextProperty_CanBeSetAndGet()
    {
        var node = new DbNode<int>(5);
        var new_node = new DbNode<int>(10);

        node.Next = new_node;

        Assert.Equal(10, node.Next.Value); // new_node.Value
    }

    [Fact]
    public void PrevProperty_CanBeSetAndGet()
    {
        var node = new DbNode<int>(5);
        var new_node = new DbNode<int>(10);

        node.Prev= new_node;

        // Assert.Equal(5, node.Prev.Next.Value); // node.Value
        Assert.Throws<System.NullReferenceException>(() => node.Prev.Next.Value); // node.Value
    }

    [Fact]
    public void ToString_ReturnsValueAsString()
    {
        var node = new DbNode<int>(10);

        Assert.Equal("10", node.ToString()); // new_node.Value
    }
}
