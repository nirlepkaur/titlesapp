var TitleForm = React.createClass({
    searchTitle: function (e) {
        e.preventDefault();
        var searchInput = React.findDOMNode(this.refs.titleName).value;
        
        
        var component = this;
        $.get("/api/title/" + searchInput, function (data) {
            component.props.displayTitles(data);
            
        });
    },
    render: function() {
        return (
            <div className="form-group row">
                  <input placeholder="Title Name" ref="titleName" />
                  <button className="search-button" onClick={this.searchTitle}>Search Title</button>

            </div>
            
    );
}
});
