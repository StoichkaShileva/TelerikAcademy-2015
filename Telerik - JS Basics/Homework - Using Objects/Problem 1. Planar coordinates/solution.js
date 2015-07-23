//Write functions for working with shapes in standard Planar coordinate system.
//Points are represented by coordinates P(X, Y)
//Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
//Calculate the distance between two points.

function Point(x, y) {
    return {
        x: x,
        y: y
    }
}
function Line(p1, p2) {
    return {
        firstPoint: p1,
        secondPoint: p2
    }
}
function calculateDistance(p1, p2) {
    return Math.max(Math.max(p1.x, p2.x) - Math.min(p1.x, p2.x), Math.max(p1.y, p2.y) - Math.min(p1.y, p2.y)) ;
}
var firstPoint = new Point(44,33);
var secondPoint = new Point(10,22);

var nLine = new Line(firstPoint, secondPoint);

var distance = calculateDistance(firstPoint,secondPoint);
console.log(distance);