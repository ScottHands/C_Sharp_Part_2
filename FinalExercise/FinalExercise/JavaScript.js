var vm = {
    bucketItem: ko.observable(),
    array: ko.observableArray(),
    addBucketItem: function () {
        this.array.push(this.bucketItem())
    }
            removebucketItem: function (bucketItem) {
        bucketItem.remove(bucketItem)
    }
};
ko.applyBindings(vm);