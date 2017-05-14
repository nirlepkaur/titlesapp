var TitleInfo = React.createClass({
    getInitialState: function () {
        return { showTitleDetail: false };
    },
    openTitleDetail: function () {
        this.setState({ showTitleDetail: true });
    },
    closeTitleDetail: function () {
        this.setState({ showTitleDetail: false });
    },
    render: function () {
        return (
          <div className="title-style">
            <div>
                <span className="title-name">{this.props.TitleDesc.TitleName}</span>
                { !this.state.showTitleDetail ? <i className="fa fa-sort-desc" aria-hidden="true" onClick={() => this.openTitleDetail() }></i> : null }
                { this.state.showTitleDetail ? <i className="fa fa-sort-asc" aria-hidden="true" onClick={() => this.closeTitleDetail() }></i> : null }
                <hr />
            </div>
            { this.state.showTitleDetail ? <TitleDetail Detail={this.props.TitleDesc } /> : null }
          </div>
    );
    }
})
var TitleDetail = React.createClass({
    render: function () {
        return (
            <div className= "detail-box" >
              <div class="form-group row">
                  <label class="col-2 col-form-label">Title Id:</label>
                  <label class="col-2 col-form-label">{this.props.Detail.TitleId }</label>

              </div>
              <div class="form-group row">
                  <label class="col-2 col-form-label">Title Name:</label>
                  <label class="col-2 col-form-label">{this.props.Detail.TitleName }</label>

              </div>
              <div class="form-group row">
                  <label class="col-2 col-form-label">Release Year:</label>
                  <label class="col-2 col-form-label">{this.props.Detail.ReleaseYear }</label>

              </div>  
            </div>
        );
    }
});
