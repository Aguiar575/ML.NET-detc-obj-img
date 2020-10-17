IEnumerable<float[]> probabilities = modelScorer.Score(imageDataView);

YoloOutputParser parser = new YoloOutputParser();

var boundingBoxes =
    probabilities
    .Select(probability => parser.ParseOutputs(probability))
    .Select(boxes => parser.FilterBoundingBoxes(boxes, 5, .5F));